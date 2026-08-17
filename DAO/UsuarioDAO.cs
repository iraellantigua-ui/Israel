using System;
using System.Data;
using System.Data.SqlClient;
using WalkiriaPapeleria.Models;

namespace WalkiriaPapeleria.DAO
{
    public class UsuarioDAO
    {
        // ==================== AUTENTICAR USUARIO ====================
        public Usuario Autenticar(string usuario, string clave)
        {
            try
            {
                string query = @"
                    SELECT 
                        u.ID_Usuario,
                        u.ID_Empleado,
                        u.ID_Rol,
                        u.Usuario,
                        u.Clave,
                        u.Estado_Usuario,
                        u.Fecha_Registro,
                        e.Nombre_Empleado,
                        e.Apellido_Empleado,
                        r.Nombre_Rol
                    FROM T_Usuarios u
                    INNER JOIN T_Empleado e ON u.ID_Empleado = e.ID_Empleado
                    INNER JOIN T_Roles r ON u.ID_Rol = r.ID_Rol
                    WHERE u.Usuario = @Usuario 
                    AND u.Clave = @Clave 
                    AND u.Estado_Usuario = 1";

                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@Usuario", usuario),
                    new SqlParameter("@Clave", clave)
                };

                DataTable result = DatabaseConnection.ExecuteQuery(query, parameters);

                if (result.Rows.Count > 0)
                {
                    DataRow row = result.Rows[0];
                    return new Usuario
                    {
                        ID_Usuario = Convert.ToInt32(row["ID_Usuario"]),
                        ID_Empleado = Convert.ToInt32(row["ID_Empleado"]),
                        ID_Rol = Convert.ToInt32(row["ID_Rol"]),
                        UsuarioNombre = row["Usuario"].ToString(),
                        Clave = row["Clave"].ToString(),
                        Estado_Usuario = Convert.ToBoolean(row["Estado_Usuario"]),
                        Fecha_Registro = Convert.ToDateTime(row["Fecha_Registro"]),
                        NombreEmpleado = row["Nombre_Empleado"].ToString(),
                        ApellidoEmpleado = row["Apellido_Empleado"].ToString(),
                        RolNombre = row["Nombre_Rol"].ToString()
                    };
                }

                return null;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al autenticar usuario: {ex.Message}");
            }
        }

        // ==================== OBTENER USUARIO POR ID ====================
        public Usuario ObtenerPorID(int idUsuario)
        {
            try
            {
                string query = @"
                    SELECT 
                        u.ID_Usuario,
                        u.ID_Empleado,
                        u.ID_Rol,
                        u.Usuario,
                        u.Clave,
                        u.Estado_Usuario,
                        u.Fecha_Registro,
                        e.Nombre_Empleado,
                        e.Apellido_Empleado,
                        r.Nombre_Rol
                    FROM T_Usuarios u
                    INNER JOIN T_Empleado e ON u.ID_Empleado = e.ID_Empleado
                    INNER JOIN T_Roles r ON u.ID_Rol = r.ID_Rol
                    WHERE u.ID_Usuario = @IDUsuario";

                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@IDUsuario", idUsuario)
                };

                DataTable result = DatabaseConnection.ExecuteQuery(query, parameters);

                if (result.Rows.Count > 0)
                {
                    DataRow row = result.Rows[0];
                    return new Usuario
                    {
                        ID_Usuario = Convert.ToInt32(row["ID_Usuario"]),
                        ID_Empleado = Convert.ToInt32(row["ID_Empleado"]),
                        ID_Rol = Convert.ToInt32(row["ID_Rol"]),
                        UsuarioNombre = row["Usuario"].ToString(),
                        Clave = row["Clave"].ToString(),
                        Estado_Usuario = Convert.ToBoolean(row["Estado_Usuario"]),
                        Fecha_Registro = Convert.ToDateTime(row["Fecha_Registro"]),
                        NombreEmpleado = row["Nombre_Empleado"].ToString(),
                        ApellidoEmpleado = row["Apellido_Empleado"].ToString(),
                        RolNombre = row["Nombre_Rol"].ToString()
                    };
                }

                return null;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener usuario: {ex.Message}");
            }
        }

        // ==================== OBTENER TODOS LOS USUARIOS ====================
        public DataTable ObtenerTodos()
        {
            try
            {
                string query = @"
                    SELECT 
                        u.ID_Usuario,
                        u.Usuario,
                        e.Nombre_Empleado + ' ' + e.Apellido_Empleado AS Empleado,
                        r.Nombre_Rol AS Rol,
                        CASE WHEN u.Estado_Usuario = 1 THEN 'Activo' ELSE 'Inactivo' END AS Estado,
                        u.Fecha_Registro
                    FROM T_Usuarios u
                    INNER JOIN T_Empleado e ON u.ID_Empleado = e.ID_Empleado
                    INNER JOIN T_Roles r ON u.ID_Rol = r.ID_Rol
                    ORDER BY u.Fecha_Registro DESC";

                return DatabaseConnection.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener usuarios: {ex.Message}");
            }
        }

        // ==================== VERIFICAR SI EXISTE USUARIO ====================
        public bool ExisteUsuario(string usuario)
        {
            try
            {
                string query = "SELECT COUNT(*) FROM T_Usuarios WHERE Usuario = @Usuario";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@Usuario", usuario)
                };

                int count = Convert.ToInt32(DatabaseConnection.ExecuteScalar(query, parameters));
                return count > 0;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al verificar usuario: {ex.Message}");
            }
        }

        // ==================== OBTENER CONTRASEÑA POR ID ====================
        public string ObtenerClavePorID(int idUsuario)
        {
            try
            {
                string query = "SELECT Clave FROM T_Usuarios WHERE ID_Usuario = @IDUsuario";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@IDUsuario", idUsuario)
                };

                object result = DatabaseConnection.ExecuteScalar(query, parameters);

                if (result != null && result != DBNull.Value)
                {
                    return result.ToString();
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener clave: {ex.Message}");
            }
        }

        // ==================== VERIFICAR SI EXISTE USUARIO POR ID ====================
        public bool ExisteUsuarioPorID(int idUsuario)
        {
            try
            {
                string query = "SELECT COUNT(*) FROM T_Usuarios WHERE ID_Usuario = @IDUsuario";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@IDUsuario", idUsuario)
                };

                int count = Convert.ToInt32(DatabaseConnection.ExecuteScalar(query, parameters));
                return count > 0;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al verificar usuario: {ex.Message}");
            }
        }
    }
}