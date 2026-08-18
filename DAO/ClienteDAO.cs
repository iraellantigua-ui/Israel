using System;
using System.Data;
using System.Data.SqlClient;
using WalkiriaPapeleria.Models;
using System.Collections.Generic;

namespace WalkiriaPapeleria.DAO
{
    public class ClienteDAO
    {
        // ==================== OBTENER TODOS LOS CLIENTES ====================
        public DataTable ObtenerTodos()
        {
            string query = @"
                SELECT 
                    c.ID_Cliente,
                    c.Cedula_Cliente,
                    c.Nombre_Cliente,
                    c.Apellido_Cliente,
                    cc.Telefono_Cliente,
                    cc.Correo_Cliente,
                    cc.Direccion_Cliente,
                    c.Fecha_Registro_Cliente
                FROM T_Cliente c
                LEFT JOIN T_Contacto_Cliente cc ON c.ID_Cliente = cc.ID_Cliente
                ORDER BY c.Nombre_Cliente, c.Apellido_Cliente";

            return DatabaseConnection.ExecuteQuery(query);
        }

        // ==================== BUSCAR CLIENTE POR CÉDULA ====================
        public DataTable BuscarPorCedula(string cedula)
        {
            string query = @"
                SELECT 
                    c.ID_Cliente,
                    c.Cedula_Cliente,
                    c.Nombre_Cliente,
                    c.Apellido_Cliente,
                    cc.Telefono_Cliente,
                    cc.Correo_Cliente,
                    cc.Direccion_Cliente,
                    c.Fecha_Registro_Cliente
                FROM T_Cliente c
                LEFT JOIN T_Contacto_Cliente cc ON c.ID_Cliente = cc.ID_Cliente
                WHERE c.Cedula_Cliente LIKE @Cedula
                ORDER BY c.Nombre_Cliente, c.Apellido_Cliente";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Cedula", $"%{cedula}%")
            };

            return DatabaseConnection.ExecuteQuery(query, parameters);
        }

        // ==================== BUSCAR CLIENTE POR NOMBRE ====================
        public DataTable BuscarPorNombre(string nombre)
        {
            string query = @"
                SELECT 
                    c.ID_Cliente,
                    c.Cedula_Cliente,
                    c.Nombre_Cliente,
                    c.Apellido_Cliente,
                    cc.Telefono_Cliente,
                    cc.Correo_Cliente,
                    cc.Direccion_Cliente,
                    c.Fecha_Registro_Cliente
                FROM T_Cliente c
                LEFT JOIN T_Contacto_Cliente cc ON c.ID_Cliente = cc.ID_Cliente
                WHERE c.Nombre_Cliente LIKE @Nombre OR c.Apellido_Cliente LIKE @Nombre
                ORDER BY c.Nombre_Cliente, c.Apellido_Cliente";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Nombre", $"%{nombre}%")
            };

            return DatabaseConnection.ExecuteQuery(query, parameters);
        }

        // ==================== OBTENER CLIENTE POR ID ====================
        public Cliente ObtenerPorID(int id)
        {
            string query = @"
                SELECT 
                    ID_Cliente,
                    Cedula_Cliente,
                    Nombre_Cliente,
                    Apellido_Cliente,
                    Fecha_Registro_Cliente
                FROM T_Cliente
                WHERE ID_Cliente = @ID";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@ID", id)
            };

            DataTable result = DatabaseConnection.ExecuteQuery(query, parameters);

            if (result.Rows.Count > 0)
            {
                DataRow row = result.Rows[0];
                return new Cliente
                {
                    ID_Cliente = Convert.ToInt32(row["ID_Cliente"]),
                    Cedula_Cliente = row["Cedula_Cliente"].ToString(),
                    Nombre_Cliente = row["Nombre_Cliente"].ToString(),
                    Apellido_Cliente = row["Apellido_Cliente"].ToString(),
                    Fecha_Registro_Cliente = Convert.ToDateTime(row["Fecha_Registro_Cliente"])
                };
            }

            return null;
        }

        // ==================== OBTENER CONTACTO POR ID CLIENTE ====================
        public ContactoCliente ObtenerContactoPorIDCliente(int idCliente)
        {
            string query = @"
                SELECT 
                    ID_Contacto_Cliente,
                    ID_Cliente,
                    Telefono_Cliente,
                    Correo_Cliente,
                    Direccion_Cliente,
                    Registro_Cliente
                FROM T_Contacto_Cliente
                WHERE ID_Cliente = @IDCliente";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@IDCliente", idCliente)
            };

            DataTable result = DatabaseConnection.ExecuteQuery(query, parameters);

            if (result.Rows.Count > 0)
            {
                DataRow row = result.Rows[0];
                return new ContactoCliente
                {
                    ID_Contacto_Cliente = Convert.ToInt32(row["ID_Contacto_Cliente"]),
                    ID_Cliente = Convert.ToInt32(row["ID_Cliente"]),
                    Telefono_Cliente = row["Telefono_Cliente"].ToString(),
                    Correo_Cliente = row["Correo_Cliente"]?.ToString(),
                    Direccion_Cliente = row["Direccion_Cliente"].ToString(),
                    Registro_Cliente = Convert.ToDateTime(row["Registro_Cliente"])
                };
            }

            return null;
        }

        // ==================== INSERTAR CLIENTE ====================
        public bool Insertar(Cliente cliente, ContactoCliente contacto)
        {
            try
            {
                // 1. Insertar en T_Cliente
                string queryCliente = @"
                    INSERT INTO T_Cliente (Cedula_Cliente, Nombre_Cliente, Apellido_Cliente)
                    VALUES (@Cedula, @Nombre, @Apellido);
                    SELECT SCOPE_IDENTITY();";

                SqlParameter[] parametersCliente = new SqlParameter[]
                {
                    new SqlParameter("@Cedula", cliente.Cedula_Cliente),
                    new SqlParameter("@Nombre", cliente.Nombre_Cliente),
                    new SqlParameter("@Apellido", cliente.Apellido_Cliente)
                };

                // Ejecutar y obtener el ID generado
                object result = DatabaseConnection.ExecuteScalar(queryCliente, parametersCliente);
                int idCliente = Convert.ToInt32(result);

                // 2. Insertar en T_Contacto_Cliente
                string queryContacto = @"
                    INSERT INTO T_Contacto_Cliente (ID_Cliente, Telefono_Cliente, Correo_Cliente, Direccion_Cliente)
                    VALUES (@IDCliente, @Telefono, @Correo, @Direccion)";

                SqlParameter[] parametersContacto = new SqlParameter[]
                {
                    new SqlParameter("@IDCliente", idCliente),
                    new SqlParameter("@Telefono", contacto.Telefono_Cliente),
                    new SqlParameter("@Correo", (object)contacto.Correo_Cliente ?? DBNull.Value),
                    new SqlParameter("@Direccion", contacto.Direccion_Cliente)
                };

                DatabaseConnection.ExecuteNonQuery(queryContacto, parametersContacto);

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al insertar cliente: {ex.Message}");
            }
        }

        // ==================== ACTUALIZAR CLIENTE ====================
        public bool Actualizar(Cliente cliente, ContactoCliente contacto)
        {
            try
            {
                // 1. Actualizar T_Cliente
                string queryCliente = @"
                    UPDATE T_Cliente
                    SET Cedula_Cliente = @Cedula,
                        Nombre_Cliente = @Nombre,
                        Apellido_Cliente = @Apellido
                    WHERE ID_Cliente = @IDCliente";

                SqlParameter[] parametersCliente = new SqlParameter[]
                {
                    new SqlParameter("@IDCliente", cliente.ID_Cliente),
                    new SqlParameter("@Cedula", cliente.Cedula_Cliente),
                    new SqlParameter("@Nombre", cliente.Nombre_Cliente),
                    new SqlParameter("@Apellido", cliente.Apellido_Cliente)
                };

                DatabaseConnection.ExecuteNonQuery(queryCliente, parametersCliente);

                // 2. Actualizar T_Contacto_Cliente
                string queryContacto = @"
                    UPDATE T_Contacto_Cliente
                    SET Telefono_Cliente = @Telefono,
                        Correo_Cliente = @Correo,
                        Direccion_Cliente = @Direccion
                    WHERE ID_Cliente = @IDCliente";

                SqlParameter[] parametersContacto = new SqlParameter[]
                {
                    new SqlParameter("@IDCliente", cliente.ID_Cliente),
                    new SqlParameter("@Telefono", contacto.Telefono_Cliente),
                    new SqlParameter("@Correo", (object)contacto.Correo_Cliente ?? DBNull.Value),
                    new SqlParameter("@Direccion", contacto.Direccion_Cliente)
                };

                DatabaseConnection.ExecuteNonQuery(queryContacto, parametersContacto);

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al actualizar cliente: {ex.Message}");
            }
        }

        // ==================== ELIMINAR CLIENTE ====================
        public bool Eliminar(int idCliente)
        {
            try
            {
                // Primero eliminar el contacto (por la FK)
                string queryContacto = "DELETE FROM T_Contacto_Cliente WHERE ID_Cliente = @IDCliente";
                SqlParameter[] parametersContacto = new SqlParameter[]
                {
                    new SqlParameter("@IDCliente", idCliente)
                };
                DatabaseConnection.ExecuteNonQuery(queryContacto, parametersContacto);

                // Luego eliminar el cliente
                string queryCliente = "DELETE FROM T_Cliente WHERE ID_Cliente = @IDCliente";
                SqlParameter[] parametersCliente = new SqlParameter[]
                {
                    new SqlParameter("@IDCliente", idCliente)
                };
                DatabaseConnection.ExecuteNonQuery(queryCliente, parametersCliente);

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al eliminar cliente: {ex.Message}");
            }
        }

        // ==================== VERIFICAR SI EXISTE CÉDULA ====================
        public bool ExisteCedula(string cedula, int idCliente = 0)
        {
            string query = "SELECT COUNT(*) FROM T_Cliente WHERE Cedula_Cliente = @Cedula";

            if (idCliente > 0)
            {
                query += " AND ID_Cliente != @IDCliente";
            }

            SqlParameter[] parameters;

            if (idCliente > 0)
            {
                parameters = new SqlParameter[]
                {
                    new SqlParameter("@Cedula", cedula),
                    new SqlParameter("@IDCliente", idCliente)
                };
            }
            else
            {
                parameters = new SqlParameter[]
                {
                    new SqlParameter("@Cedula", cedula)
                };
            }

            int count = Convert.ToInt32(DatabaseConnection.ExecuteScalar(query, parameters));
            return count > 0;
        }
    }
}