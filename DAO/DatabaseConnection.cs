using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace WalkiriaPapeleria.DAO
{
    public class DatabaseConnection
    {
        // Obtener la cadena de conexión del App.config
        private static string connectionString =
            ConfigurationManager.ConnectionStrings["WalkiriaConnection"].ConnectionString;

        private static SqlConnection connection = null;

        // Obtener conexión abierta
        public static SqlConnection GetConnection()
        {
            try
            {
                if (connection == null || connection.State == ConnectionState.Closed)
                {
                    connection = new SqlConnection(connectionString);
                }
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                    Console.WriteLine("✅ Conexión abierta exitosamente.");
                }
                return connection;
            }
            catch (Exception ex)
            {
                throw new Exception($"❌ Error de conexión: {ex.Message}");
            }
        }

        // Cerrar conexión
        public static void CloseConnection()
        {
            try
            {
                if (connection != null && connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                    Console.WriteLine("🔒 Conexión cerrada.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"❌ Error al cerrar conexión: {ex.Message}");
            }
        }

        // Probar conexión
        public static bool TestConnection()
        {
            try
            {
                using (SqlConnection testConn = new SqlConnection(connectionString))
                {
                    testConn.Open();
                    Console.WriteLine("✅ Prueba de conexión exitosa!");
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Error en prueba de conexión: {ex.Message}");
                return false;
            }
        }

        // Ejecutar consulta que devuelve datos (SELECT)
        public static DataTable ExecuteQuery(string query, SqlParameter[] parameters = null)
        {
            try
            {
                using (SqlCommand command = new SqlCommand(query, GetConnection()))
                {
                    if (parameters != null)
                        command.Parameters.AddRange(parameters);

                    DataTable dataTable = new DataTable();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"❌ Error en ExecuteQuery: {ex.Message}");
            }
            finally
            {
                CloseConnection();
            }
        }

        // Ejecutar comando que no devuelve datos (INSERT, UPDATE, DELETE)
        public static int ExecuteNonQuery(string query, SqlParameter[] parameters = null)
        {
            try
            {
                using (SqlCommand command = new SqlCommand(query, GetConnection()))
                {
                    if (parameters != null)
                        command.Parameters.AddRange(parameters);

                    return command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"❌ Error en ExecuteNonQuery: {ex.Message}");
            }
            finally
            {
                CloseConnection();
            }
        }

        // Ejecutar y obtener un solo valor (SELECT COUNT, etc.)
        public static object ExecuteScalar(string query, SqlParameter[] parameters = null)
        {
            try
            {
                using (SqlCommand command = new SqlCommand(query, GetConnection()))
                {
                    if (parameters != null)
                        command.Parameters.AddRange(parameters);

                    return command.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"❌ Error en ExecuteScalar: {ex.Message}");
            }
            finally
            {
                CloseConnection();
            }
        }

        // ==================== REINICIAR SISTEMA ====================
        public static bool ReiniciarSistema()
        {
            try
            {
                string script = @"
            -- ============================================
            -- 1. DESACTIVAR RESTRICCIONES DE CLAVE FORÁNEA
            -- ============================================
            EXEC sp_MSforeachtable 'ALTER TABLE ? NOCHECK CONSTRAINT ALL';
            GO

            -- ============================================
            -- 2. ELIMINAR DATOS DE TODAS LAS TABLAS
            -- ============================================
            DELETE FROM T_Detalle_Factura;
            DELETE FROM T_Factura;
            DELETE FROM T_Asignacion_Turno;
            DELETE FROM T_Cierre_Caja;
            DELETE FROM T_Contacto_Cliente;
            DELETE FROM T_Cliente;
            DELETE FROM T_Contacto_Empleado;
            DELETE FROM T_Estatus_Empleado;
            DELETE FROM T_Usuarios;
            DELETE FROM T_Empleado;
            DELETE FROM T_Producto;
            DELETE FROM T_Servicio;
            DELETE FROM T_Roles;
            DELETE FROM T_Metodo_Pago;
            DELETE FROM T_Datos_Negocio;
            DELETE FROM T_Turno;
            GO

            -- ============================================
            -- 3. REINICIAR CONTADORES IDENTITY
            -- ============================================
            DBCC CHECKIDENT ('T_Detalle_Factura', RESEED, 0);
            DBCC CHECKIDENT ('T_Factura', RESEED, 0);
            DBCC CHECKIDENT ('T_Asignacion_Turno', RESEED, 0);
            DBCC CHECKIDENT ('T_Cierre_Caja', RESEED, 0);
            DBCC CHECKIDENT ('T_Contacto_Cliente', RESEED, 0);
            DBCC CHECKIDENT ('T_Contacto_Empleado', RESEED, 0);
            DBCC CHECKIDENT ('T_Estatus_Empleado', RESEED, 0);
            DBCC CHECKIDENT ('T_Usuarios', RESEED, 0);
            DBCC CHECKIDENT ('T_Cliente', RESEED, 0);
            DBCC CHECKIDENT ('T_Empleado', RESEED, 0);
            DBCC CHECKIDENT ('T_Producto', RESEED, 0);
            DBCC CHECKIDENT ('T_Servicio', RESEED, 0);
            DBCC CHECKIDENT ('T_Turno', RESEED, 0);
            DBCC CHECKIDENT ('T_Metodo_Pago', RESEED, 0);
            DBCC CHECKIDENT ('T_Datos_Negocio', RESEED, 0);
            DBCC CHECKIDENT ('T_Roles', RESEED, 0);
            GO

            -- ============================================
            -- 4. REACTIVAR RESTRICCIONES
            -- ============================================
            EXEC sp_MSforeachtable 'ALTER TABLE ? CHECK CONSTRAINT ALL';
            GO

            -- ============================================
            -- 5. INSERTAR DATOS BÁSICOS (Roles, Turnos, Métodos Pago)
            -- ============================================
            INSERT INTO T_Roles (Nombre_Rol) VALUES ('Administrador');
            INSERT INTO T_Roles (Nombre_Rol) VALUES ('Supervisor');
            INSERT INTO T_Roles (Nombre_Rol) VALUES ('Cajero');
            GO

            INSERT INTO T_Metodo_Pago (Metodo_Pago) VALUES ('EFECTIVO');
            INSERT INTO T_Metodo_Pago (Metodo_Pago) VALUES ('TRANSFERENCIA');
            INSERT INTO T_Metodo_Pago (Metodo_Pago) VALUES ('TARJETA');
            GO

            INSERT INTO T_Turno (Nombre_Turno, Hora_Inicio, Hora_Fin)
            VALUES ('Matutino', '08:00:00', '14:00:00');
            INSERT INTO T_Turno (Nombre_Turno, Hora_Inicio, Hora_Fin)
            VALUES ('Vespertino', '14:00:00', '20:00:00');
            GO

            -- ============================================
            -- 6. INSERTAR DATOS DEL NEGOCIO
            -- ============================================
            INSERT INTO T_Datos_Negocio (Nombre_Negocio, RNC, Telefono, Correo, Direccion, ITBIS)
            VALUES ('PAPELERIA WALKIRIA', '130987654', '8095070000', 'info@papeleriawalkiria.com', 'Nagua, República Dominicana', 0.18);
            GO

            -- ============================================
            -- 7. INSERTAR ADMINISTRADOR
            -- ============================================
            INSERT INTO T_Empleado (Cedula_Empleado, Nombre_Empleado, Apellido_Empleado, Sexo, Fecha_Nacimiento, Tipo_Sangre)
            VALUES ('00112345678', 'Walkiria', 'Rodriguez', 'F', '1970-05-15', 'O+');
            GO

            INSERT INTO T_Contacto_Empleado (ID_Empleado, Celular_Empleado, Correo_Empleado, Direccion_Empleado)
            VALUES (1, '8095070000', 'admin@papeleriawalkiria.com', 'Nagua, República Dominicana');
            GO

            INSERT INTO T_Estatus_Empleado (ID_Empleado, Estatus_Empleado)
            VALUES (1, 1);
            GO

            INSERT INTO T_Usuarios (ID_Empleado, ID_Rol, Usuario, Clave, Estado_Usuario)
            VALUES (1, 1, 'Walkiria', '123456', 1);
            GO
        ";

                // Ejecutar el script completo
                using (SqlCommand command = new SqlCommand(script, GetConnection()))
                {
                    command.CommandTimeout = 300; // 5 minutos de timeout
                    command.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al reiniciar el sistema: {ex.Message}");
            }
            finally
            {
                CloseConnection();
            }
        }



    }
}