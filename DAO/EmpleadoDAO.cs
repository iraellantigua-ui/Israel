using System;
using System.Data;
using System.Data.SqlClient;
using WalkiriaPapeleria.Models;
using System.Collections.Generic;

namespace WalkiriaPapeleria.DAO
{
    public class EmpleadoDAO
    {
        // ==================== OBTENER TODOS LOS EMPLEADOS ====================
        public DataTable ObtenerTodos()
        {
            string query = @"
                SELECT 
                    e.ID_Empleado,
                    e.Cedula_Empleado,
                    e.Nombre_Empleado,
                    e.Apellido_Empleado,
                    e.Sexo,
                    e.Fecha_Nacimiento,
                    e.Tipo_Sangre,
                    e.Fecha_Registro,
                    ce.Celular_Empleado,
                    ce.Telefono_Extra,
                    ce.Correo_Empleado,
                    ce.Direccion_Empleado,
                    ee.Estatus_Empleado,
                    u.ID_Usuario,
                    u.Usuario,
                    u.Estado_Usuario,
                    r.ID_Rol,
                    r.Nombre_Rol
                FROM T_Empleado e
                LEFT JOIN T_Contacto_Empleado ce ON e.ID_Empleado = ce.ID_Empleado
                LEFT JOIN T_Estatus_Empleado ee ON e.ID_Empleado = ee.ID_Empleado
                LEFT JOIN T_Usuarios u ON e.ID_Empleado = u.ID_Empleado
                LEFT JOIN T_Roles r ON u.ID_Rol = r.ID_Rol
                ORDER BY e.Nombre_Empleado, e.Apellido_Empleado";

            return DatabaseConnection.ExecuteQuery(query);
        }

        // ==================== OBTENER EMPLEADO POR ID ====================
        public Empleado ObtenerPorID(int id)
        {
            string query = @"
                SELECT 
                    e.ID_Empleado,
                    e.Cedula_Empleado,
                    e.Nombre_Empleado,
                    e.Apellido_Empleado,
                    e.Sexo,
                    e.Fecha_Nacimiento,
                    e.Tipo_Sangre,
                    e.Fecha_Registro,
                    ce.Celular_Empleado,
                    ce.Telefono_Extra,
                    ce.Correo_Empleado,
                    ce.Direccion_Empleado,
                    ee.Estatus_Empleado,
                    u.ID_Usuario,
                    u.Usuario,
                    u.Estado_Usuario,
                    r.ID_Rol,
                    r.Nombre_Rol
                FROM T_Empleado e
                LEFT JOIN T_Contacto_Empleado ce ON e.ID_Empleado = ce.ID_Empleado
                LEFT JOIN T_Estatus_Empleado ee ON e.ID_Empleado = ee.ID_Empleado
                LEFT JOIN T_Usuarios u ON e.ID_Empleado = u.ID_Empleado
                LEFT JOIN T_Roles r ON u.ID_Rol = r.ID_Rol
                WHERE e.ID_Empleado = @ID";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@ID", id)
            };

            DataTable result = DatabaseConnection.ExecuteQuery(query, parameters);

            if (result.Rows.Count > 0)
            {
                DataRow row = result.Rows[0];
                return new Empleado
                {
                    ID_Empleado = Convert.ToInt32(row["ID_Empleado"]),
                    Cedula_Empleado = row["Cedula_Empleado"].ToString(),
                    Nombre_Empleado = row["Nombre_Empleado"].ToString(),
                    Apellido_Empleado = row["Apellido_Empleado"].ToString(),
                    Sexo = row["Sexo"].ToString(),
                    Fecha_Nacimiento = Convert.ToDateTime(row["Fecha_Nacimiento"]),
                    Tipo_Sangre = row["Tipo_Sangre"]?.ToString(),
                    Fecha_Registro = Convert.ToDateTime(row["Fecha_Registro"]),
                    Celular_Empleado = row["Celular_Empleado"]?.ToString(),
                    Telefono_Extra = row["Telefono_Extra"]?.ToString(),
                    Correo_Empleado = row["Correo_Empleado"]?.ToString(),
                    Direccion_Empleado = row["Direccion_Empleado"]?.ToString(),
                    Estatus_Empleado = row["Estatus_Empleado"] != DBNull.Value && Convert.ToBoolean(row["Estatus_Empleado"]),
                    ID_Usuario = row["ID_Usuario"] != DBNull.Value ? Convert.ToInt32(row["ID_Usuario"]) : 0,
                    Usuario = row["Usuario"]?.ToString(),
                    Estado_Usuario = row["Estado_Usuario"] != DBNull.Value && Convert.ToBoolean(row["Estado_Usuario"]),
                    ID_Rol = row["ID_Rol"] != DBNull.Value ? Convert.ToInt32(row["ID_Rol"]) : 0,
                    Nombre_Rol = row["Nombre_Rol"]?.ToString()
                };
            }

            return null;
        }

        // ==================== OBTENER ROLES ====================
        public DataTable ObtenerRoles()
        {
            string query = "SELECT ID_Rol, Nombre_Rol FROM T_Roles ORDER BY Nombre_Rol";
            return DatabaseConnection.ExecuteQuery(query);
        }

        // ==================== BUSCAR EMPLEADO POR CÉDULA ====================
        public DataTable BuscarPorCedula(string cedula)
        {
            string query = @"
                SELECT 
                    e.ID_Empleado,
                    e.Cedula_Empleado,
                    e.Nombre_Empleado,
                    e.Apellido_Empleado,
                    e.Sexo,
                    e.Fecha_Nacimiento,
                    e.Tipo_Sangre,
                    ce.Celular_Empleado,
                    ce.Telefono_Extra,
                    ce.Correo_Empleado,
                    ce.Direccion_Empleado,
                    ee.Estatus_Empleado,
                    r.Nombre_Rol
                FROM T_Empleado e
                LEFT JOIN T_Contacto_Empleado ce ON e.ID_Empleado = ce.ID_Empleado
                LEFT JOIN T_Estatus_Empleado ee ON e.ID_Empleado = ee.ID_Empleado
                LEFT JOIN T_Usuarios u ON e.ID_Empleado = u.ID_Empleado
                LEFT JOIN T_Roles r ON u.ID_Rol = r.ID_Rol
                WHERE e.Cedula_Empleado LIKE @Cedula
                ORDER BY e.Nombre_Empleado, e.Apellido_Empleado";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Cedula", $"%{cedula}%")
            };

            return DatabaseConnection.ExecuteQuery(query, parameters);
        }

        // ==================== VERIFICAR SI EXISTE CÉDULA ====================
        public bool ExisteCedula(string cedula, int idEmpleado = 0)
        {
            string query = "SELECT COUNT(*) FROM T_Empleado WHERE Cedula_Empleado = @Cedula";

            if (idEmpleado > 0)
            {
                query += " AND ID_Empleado != @ID";
            }

            SqlParameter[] parameters;

            if (idEmpleado > 0)
            {
                parameters = new SqlParameter[]
                {
                    new SqlParameter("@Cedula", cedula),
                    new SqlParameter("@ID", idEmpleado)
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

        // ==================== VERIFICAR SI EXISTE USUARIO ====================
        public bool ExisteUsuario(string usuario, int idEmpleado = 0)
        {
            string query = "SELECT COUNT(*) FROM T_Usuarios WHERE Usuario = @Usuario";

            if (idEmpleado > 0)
            {
                query += " AND ID_Empleado != @ID";
            }

            SqlParameter[] parameters;

            if (idEmpleado > 0)
            {
                parameters = new SqlParameter[]
                {
                    new SqlParameter("@Usuario", usuario),
                    new SqlParameter("@ID", idEmpleado)
                };
            }
            else
            {
                parameters = new SqlParameter[]
                {
                    new SqlParameter("@Usuario", usuario)
                };
            }

            int count = Convert.ToInt32(DatabaseConnection.ExecuteScalar(query, parameters));
            return count > 0;
        }

        // ==================== OBTENER ÚLTIMO ID DE EMPLEADO ====================
        public int ObtenerUltimoID()
        {
            string query = "SELECT ISNULL(MAX(ID_Empleado), 0) FROM T_Empleado";
            object result = DatabaseConnection.ExecuteScalar(query);
            return Convert.ToInt32(result);
        }

        // ==================== INSERTAR EMPLEADO COMPLETO ====================
        public bool Insertar(Empleado empleado)
        {
            try
            {
                // 1. Verificar si la cédula ya existe
                if (ExisteCedula(empleado.Cedula_Empleado))
                {
                    throw new Exception($"Ya existe un empleado con la cédula {empleado.Cedula_Empleado}");
                }

                // 2. Insertar en T_Empleado
                string queryEmpleado = @"
                    INSERT INTO T_Empleado 
                    (Cedula_Empleado, Nombre_Empleado, Apellido_Empleado, Sexo, Fecha_Nacimiento, Tipo_Sangre)
                    VALUES (@Cedula, @Nombre, @Apellido, @Sexo, @FechaNac, @TipoSangre);
                    SELECT SCOPE_IDENTITY();";

                SqlParameter[] parametersEmpleado = new SqlParameter[]
                {
                    new SqlParameter("@Cedula", empleado.Cedula_Empleado),
                    new SqlParameter("@Nombre", empleado.Nombre_Empleado),
                    new SqlParameter("@Apellido", empleado.Apellido_Empleado),
                    new SqlParameter("@Sexo", empleado.Sexo),
                    new SqlParameter("@FechaNac", empleado.Fecha_Nacimiento),
                    new SqlParameter("@TipoSangre", (object)empleado.Tipo_Sangre ?? DBNull.Value)
                };

                object result = DatabaseConnection.ExecuteScalar(queryEmpleado, parametersEmpleado);
                int idEmpleado = Convert.ToInt32(result);

                // 3. Insertar en T_Contacto_Empleado
                string queryContacto = @"
                    INSERT INTO T_Contacto_Empleado 
                    (ID_Empleado, Celular_Empleado, Telefono_Extra, Correo_Empleado, Direccion_Empleado)
                    VALUES (@IDEmpleado, @Celular, @TelefonoExtra, @Correo, @Direccion)";

                SqlParameter[] parametersContacto = new SqlParameter[]
                {
                    new SqlParameter("@IDEmpleado", idEmpleado),
                    new SqlParameter("@Celular", empleado.Celular_Empleado),
                    new SqlParameter("@TelefonoExtra", (object)empleado.Telefono_Extra ?? DBNull.Value),
                    new SqlParameter("@Correo", empleado.Correo_Empleado),
                    new SqlParameter("@Direccion", empleado.Direccion_Empleado)
                };

                DatabaseConnection.ExecuteNonQuery(queryContacto, parametersContacto);

                // 4. Insertar en T_Estatus_Empleado
                string queryEstatus = @"
                    INSERT INTO T_Estatus_Empleado (ID_Empleado, Estatus_Empleado)
                    VALUES (@IDEmpleado, @Estatus)";

                SqlParameter[] parametersEstatus = new SqlParameter[]
                {
                    new SqlParameter("@IDEmpleado", idEmpleado),
                    new SqlParameter("@Estatus", empleado.Estatus_Empleado)
                };

                DatabaseConnection.ExecuteNonQuery(queryEstatus, parametersEstatus);

                // 5. Insertar en T_Usuarios (si tiene usuario)
                if (!string.IsNullOrEmpty(empleado.Usuario))
                {
                    // Verificar si el nombre de usuario ya existe
                    if (ExisteUsuario(empleado.Usuario))
                    {
                        throw new Exception($"El usuario '{empleado.Usuario}' ya está en uso");
                    }

                    string queryUsuario = @"
                        INSERT INTO T_Usuarios 
                        (ID_Empleado, ID_Rol, Usuario, Clave, Estado_Usuario)
                        VALUES (@IDEmpleado, @IDRol, @Usuario, @Clave, @EstadoUsuario)";

                    SqlParameter[] parametersUsuario = new SqlParameter[]
                    {
                        new SqlParameter("@IDEmpleado", idEmpleado),
                        new SqlParameter("@IDRol", empleado.ID_Rol),
                        new SqlParameter("@Usuario", empleado.Usuario),
                        new SqlParameter("@Clave", empleado.Clave),
                        new SqlParameter("@EstadoUsuario", empleado.Estado_Usuario)
                    };

                    DatabaseConnection.ExecuteNonQuery(queryUsuario, parametersUsuario);
                }

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al insertar empleado: {ex.Message}");
            }
        }

        // ==================== ACTUALIZAR EMPLEADO ====================
        public bool Actualizar(Empleado empleado)
        {
            try
            {
                // 1. Actualizar T_Empleado
                string queryEmpleado = @"
                    UPDATE T_Empleado
                    SET Cedula_Empleado = @Cedula,
                        Nombre_Empleado = @Nombre,
                        Apellido_Empleado = @Apellido,
                        Sexo = @Sexo,
                        Fecha_Nacimiento = @FechaNac,
                        Tipo_Sangre = @TipoSangre
                    WHERE ID_Empleado = @ID";

                SqlParameter[] parametersEmpleado = new SqlParameter[]
                {
                    new SqlParameter("@ID", empleado.ID_Empleado),
                    new SqlParameter("@Cedula", empleado.Cedula_Empleado),
                    new SqlParameter("@Nombre", empleado.Nombre_Empleado),
                    new SqlParameter("@Apellido", empleado.Apellido_Empleado),
                    new SqlParameter("@Sexo", empleado.Sexo),
                    new SqlParameter("@FechaNac", empleado.Fecha_Nacimiento),
                    new SqlParameter("@TipoSangre", (object)empleado.Tipo_Sangre ?? DBNull.Value)
                };

                DatabaseConnection.ExecuteNonQuery(queryEmpleado, parametersEmpleado);

                // 2. Actualizar T_Contacto_Empleado
                string queryContacto = @"
                    UPDATE T_Contacto_Empleado
                    SET Celular_Empleado = @Celular,
                        Telefono_Extra = @TelefonoExtra,
                        Correo_Empleado = @Correo,
                        Direccion_Empleado = @Direccion
                    WHERE ID_Empleado = @ID";

                SqlParameter[] parametersContacto = new SqlParameter[]
                {
                    new SqlParameter("@ID", empleado.ID_Empleado),
                    new SqlParameter("@Celular", empleado.Celular_Empleado),
                    new SqlParameter("@TelefonoExtra", (object)empleado.Telefono_Extra ?? DBNull.Value),
                    new SqlParameter("@Correo", empleado.Correo_Empleado),
                    new SqlParameter("@Direccion", empleado.Direccion_Empleado)
                };

                DatabaseConnection.ExecuteNonQuery(queryContacto, parametersContacto);

                // 3. Actualizar T_Estatus_Empleado
                string queryEstatus = @"
                    UPDATE T_Estatus_Empleado
                    SET Estatus_Empleado = @Estatus
                    WHERE ID_Empleado = @ID";

                SqlParameter[] parametersEstatus = new SqlParameter[]
                {
                    new SqlParameter("@ID", empleado.ID_Empleado),
                    new SqlParameter("@Estatus", empleado.Estatus_Empleado)
                };

                DatabaseConnection.ExecuteNonQuery(queryEstatus, parametersEstatus);

                // 4. Actualizar o Insertar en T_Usuarios
                if (!string.IsNullOrEmpty(empleado.Usuario))
                {
                    string queryCheck = "SELECT COUNT(*) FROM T_Usuarios WHERE ID_Empleado = @ID";
                    SqlParameter[] parametersCheck = new SqlParameter[]
                    {
                        new SqlParameter("@ID", empleado.ID_Empleado)
                    };

                    int count = Convert.ToInt32(DatabaseConnection.ExecuteScalar(queryCheck, parametersCheck));

                    if (count > 0)
                    {
                        string queryUsuario = @"
                            UPDATE T_Usuarios
                            SET ID_Rol = @IDRol,
                                Usuario = @Usuario,
                                Clave = @Clave,
                                Estado_Usuario = @EstadoUsuario
                            WHERE ID_Empleado = @ID";

                        SqlParameter[] parametersUsuario = new SqlParameter[]
                        {
                            new SqlParameter("@ID", empleado.ID_Empleado),
                            new SqlParameter("@IDRol", empleado.ID_Rol),
                            new SqlParameter("@Usuario", empleado.Usuario),
                            new SqlParameter("@Clave", empleado.Clave),
                            new SqlParameter("@EstadoUsuario", empleado.Estado_Usuario)
                        };

                        DatabaseConnection.ExecuteNonQuery(queryUsuario, parametersUsuario);
                    }
                    else
                    {
                        string queryUsuario = @"
                            INSERT INTO T_Usuarios 
                            (ID_Empleado, ID_Rol, Usuario, Clave, Estado_Usuario)
                            VALUES (@ID, @IDRol, @Usuario, @Clave, @EstadoUsuario)";

                        SqlParameter[] parametersUsuario = new SqlParameter[]
                        {
                            new SqlParameter("@ID", empleado.ID_Empleado),
                            new SqlParameter("@IDRol", empleado.ID_Rol),
                            new SqlParameter("@Usuario", empleado.Usuario),
                            new SqlParameter("@Clave", empleado.Clave),
                            new SqlParameter("@EstadoUsuario", empleado.Estado_Usuario)
                        };

                        DatabaseConnection.ExecuteNonQuery(queryUsuario, parametersUsuario);
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al actualizar empleado: {ex.Message}");
            }
        }

        // ==================== ELIMINAR EMPLEADO ====================
        public bool Eliminar(int idEmpleado)
        {
            try
            {
                // 1. Eliminar usuario (si existe)
                string queryUsuario = "DELETE FROM T_Usuarios WHERE ID_Empleado = @ID";
                SqlParameter[] parametersUsuario = new SqlParameter[]
                {
                    new SqlParameter("@ID", idEmpleado)
                };
                DatabaseConnection.ExecuteNonQuery(queryUsuario, parametersUsuario);

                // 2. Eliminar estatus
                string queryEstatus = "DELETE FROM T_Estatus_Empleado WHERE ID_Empleado = @ID";
                SqlParameter[] parametersEstatus = new SqlParameter[]
                {
                    new SqlParameter("@ID", idEmpleado)
                };
                DatabaseConnection.ExecuteNonQuery(queryEstatus, parametersEstatus);

                // 3. Eliminar contacto
                string queryContacto = "DELETE FROM T_Contacto_Empleado WHERE ID_Empleado = @ID";
                SqlParameter[] parametersContacto = new SqlParameter[]
                {
                    new SqlParameter("@ID", idEmpleado)
                };
                DatabaseConnection.ExecuteNonQuery(queryContacto, parametersContacto);

                // 4. Eliminar empleado
                string queryEmpleado = "DELETE FROM T_Empleado WHERE ID_Empleado = @ID";
                SqlParameter[] parametersEmpleado = new SqlParameter[]
                {
                    new SqlParameter("@ID", idEmpleado)
                };
                DatabaseConnection.ExecuteNonQuery(queryEmpleado, parametersEmpleado);

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al eliminar empleado: {ex.Message}");
            }
        }

        // ==================== VERIFICAR SI UN EMPLEADO TIENE USUARIO ====================
        public bool TieneUsuario(int idEmpleado)
        {
            string query = "SELECT COUNT(*) FROM T_Usuarios WHERE ID_Empleado = @IDEmpleado";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@IDEmpleado", idEmpleado)
            };

            int count = Convert.ToInt32(DatabaseConnection.ExecuteScalar(query, parameters));
            return count > 0;
        }
    }
}