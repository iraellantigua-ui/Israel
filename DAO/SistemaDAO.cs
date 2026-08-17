using System;
using System.Data;
using System.Data.SqlClient;
using WalkiriaPapeleria.Models;

namespace WalkiriaPapeleria.DAO
{
    public class ServicioDAO
    {
        // ==================== OBTENER TODOS LOS SERVICIOS ====================
        public DataTable ObtenerTodos()
        {
            string query = @"
                SELECT 
                    ID_Servicio,
                    Nombre_Servicio,
                    Descripcion_Servicio,
                    Precio_Servicio,
                    Estado_Servicio,
                    Fecha_Registro
                FROM T_Servicio
                ORDER BY Nombre_Servicio";

            return DatabaseConnection.ExecuteQuery(query);
        }

        // ==================== OBTENER SOLO SERVICIOS ACTIVOS ====================
        public DataTable ObtenerActivos()
        {
            string query = @"
                SELECT 
                    ID_Servicio,
                    Nombre_Servicio,
                    Descripcion_Servicio,
                    Precio_Servicio,
                    Estado_Servicio
                FROM T_Servicio
                WHERE Estado_Servicio = 1
                ORDER BY Nombre_Servicio";

            return DatabaseConnection.ExecuteQuery(query);
        }

        // ==================== BUSCAR SERVICIOS POR NOMBRE ====================
        public DataTable BuscarPorNombre(string nombre)
        {
            string query = @"
                SELECT 
                    ID_Servicio,
                    Nombre_Servicio,
                    Descripcion_Servicio,
                    Precio_Servicio,
                    Estado_Servicio,
                    Fecha_Registro
                FROM T_Servicio
                WHERE Nombre_Servicio LIKE @Nombre
                ORDER BY Nombre_Servicio";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Nombre", $"%{nombre}%")
            };

            return DatabaseConnection.ExecuteQuery(query, parameters);
        }

        // ==================== OBTENER SERVICIO POR ID ====================
        public Servicio ObtenerPorID(int id)
        {
            string query = @"
                SELECT 
                    ID_Servicio,
                    Nombre_Servicio,
                    Descripcion_Servicio,
                    Precio_Servicio,
                    Estado_Servicio,
                    Fecha_Registro
                FROM T_Servicio
                WHERE ID_Servicio = @ID";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@ID", id)
            };

            DataTable result = DatabaseConnection.ExecuteQuery(query, parameters);

            if (result.Rows.Count > 0)
            {
                DataRow row = result.Rows[0];
                return new Servicio
                {
                    ID_Servicio = Convert.ToInt32(row["ID_Servicio"]),
                    Nombre_Servicio = row["Nombre_Servicio"].ToString(),
                    Descripcion_Servicio = row["Descripcion_Servicio"]?.ToString(),
                    Precio_Servicio = Convert.ToDecimal(row["Precio_Servicio"]),
                    Estado_Servicio = Convert.ToBoolean(row["Estado_Servicio"]),
                    Fecha_Registro = Convert.ToDateTime(row["Fecha_Registro"])
                };
            }

            return null;
        }

        // ==================== INSERTAR SERVICIO ====================
        public bool Insertar(Servicio servicio)
        {
            try
            {
                string query = @"
                    INSERT INTO T_Servicio 
                    (Nombre_Servicio, Descripcion_Servicio, Precio_Servicio, Estado_Servicio)
                    VALUES (@Nombre, @Descripcion, @Precio, @Estado)";

                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@Nombre", servicio.Nombre_Servicio),
                    new SqlParameter("@Descripcion", (object)servicio.Descripcion_Servicio ?? DBNull.Value),
                    new SqlParameter("@Precio", servicio.Precio_Servicio),
                    new SqlParameter("@Estado", servicio.Estado_Servicio)
                };

                DatabaseConnection.ExecuteNonQuery(query, parameters);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al insertar servicio: {ex.Message}");
            }
        }

        // ==================== ACTUALIZAR SERVICIO ====================
        public bool Actualizar(Servicio servicio)
        {
            try
            {
                string query = @"
                    UPDATE T_Servicio
                    SET Nombre_Servicio = @Nombre,
                        Descripcion_Servicio = @Descripcion,
                        Precio_Servicio = @Precio,
                        Estado_Servicio = @Estado
                    WHERE ID_Servicio = @ID";

                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@ID", servicio.ID_Servicio),
                    new SqlParameter("@Nombre", servicio.Nombre_Servicio),
                    new SqlParameter("@Descripcion", (object)servicio.Descripcion_Servicio ?? DBNull.Value),
                    new SqlParameter("@Precio", servicio.Precio_Servicio),
                    new SqlParameter("@Estado", servicio.Estado_Servicio)
                };

                DatabaseConnection.ExecuteNonQuery(query, parameters);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al actualizar servicio: {ex.Message}");
            }
        }

        // ==================== ELIMINAR SERVICIO ====================
        public bool Eliminar(int idServicio)
        {
            try
            {
                string query = "DELETE FROM T_Servicio WHERE ID_Servicio = @ID";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@ID", idServicio)
                };

                DatabaseConnection.ExecuteNonQuery(query, parameters);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al eliminar servicio: {ex.Message}");
            }
        }

        // ==================== VERIFICAR SI EXISTE SERVICIO ====================
        public bool ExisteNombre(string nombre, int idServicio = 0)
        {
            string query = "SELECT COUNT(*) FROM T_Servicio WHERE Nombre_Servicio = @Nombre";

            if (idServicio > 0)
            {
                query += " AND ID_Servicio != @ID";
            }

            SqlParameter[] parameters;

            if (idServicio > 0)
            {
                parameters = new SqlParameter[]
                {
                    new SqlParameter("@Nombre", nombre),
                    new SqlParameter("@ID", idServicio)
                };
            }
            else
            {
                parameters = new SqlParameter[]
                {
                    new SqlParameter("@Nombre", nombre)
                };
            }

            int count = Convert.ToInt32(DatabaseConnection.ExecuteScalar(query, parameters));
            return count > 0;
        }
    }
}