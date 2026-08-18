using System;
using System.Data;
using System.Data.SqlClient;
using WalkiriaPapeleria.Models;

namespace WalkiriaPapeleria.DAO
{
    public class ProductoDAO
    {
        // ==================== OBTENER TODOS LOS PRODUCTOS ====================
        public DataTable ObtenerTodos()
        {
            string query = @"
                SELECT 
                    ID_Producto,
                    Nombre_Producto,
                    Descripcion_Producto,
                    Precio_Venta,
                    Cantidad_Disponible,
                    Estado_Producto,
                    Fecha_Registro
                FROM T_Producto
                ORDER BY Nombre_Producto";

            return DatabaseConnection.ExecuteQuery(query);
        }

        // ==================== OBTENER SOLO PRODUCTOS ACTIVOS ====================
        public DataTable ObtenerActivos()
        {
            string query = @"
                SELECT 
                    ID_Producto,
                    Nombre_Producto,
                    Descripcion_Producto,
                    Precio_Venta,
                    Cantidad_Disponible,
                    Estado_Producto
                FROM T_Producto
                WHERE Estado_Producto = 1
                ORDER BY Nombre_Producto";

            return DatabaseConnection.ExecuteQuery(query);
        }

        // ==================== BUSCAR PRODUCTOS POR NOMBRE ====================
        public DataTable BuscarPorNombre(string nombre)
        {
            string query = @"
                SELECT 
                    ID_Producto,
                    Nombre_Producto,
                    Descripcion_Producto,
                    Precio_Venta,
                    Cantidad_Disponible,
                    Estado_Producto,
                    Fecha_Registro
                FROM T_Producto
                WHERE Nombre_Producto LIKE @Nombre
                ORDER BY Nombre_Producto";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Nombre", $"%{nombre}%")
            };

            return DatabaseConnection.ExecuteQuery(query, parameters);
        }

        // ==================== OBTENER PRODUCTO POR ID ====================
        public Producto ObtenerPorID(int id)
        {
            string query = @"
                SELECT 
                    ID_Producto,
                    Nombre_Producto,
                    Descripcion_Producto,
                    Precio_Venta,
                    Cantidad_Disponible,
                    Estado_Producto,
                    Fecha_Registro
                FROM T_Producto
                WHERE ID_Producto = @ID";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@ID", id)
            };

            DataTable result = DatabaseConnection.ExecuteQuery(query, parameters);

            if (result.Rows.Count > 0)
            {
                DataRow row = result.Rows[0];
                return new Producto
                {
                    ID_Producto = Convert.ToInt32(row["ID_Producto"]),
                    Nombre_Producto = row["Nombre_Producto"].ToString(),
                    Descripcion_Producto = row["Descripcion_Producto"]?.ToString(),
                    Precio_Venta = Convert.ToDecimal(row["Precio_Venta"]),
                    Cantidad_Disponible = Convert.ToInt32(row["Cantidad_Disponible"]),
                    Estado_Producto = Convert.ToBoolean(row["Estado_Producto"]),
                    Fecha_Registro = Convert.ToDateTime(row["Fecha_Registro"])
                };
            }

            return null;
        }

        // ==================== INSERTAR PRODUCTO ====================
        public bool Insertar(Producto producto)
        {
            try
            {
                string query = @"
                    INSERT INTO T_Producto 
                    (Nombre_Producto, Descripcion_Producto, Precio_Venta, Cantidad_Disponible, Estado_Producto)
                    VALUES (@Nombre, @Descripcion, @Precio, @Cantidad, @Estado)";

                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@Nombre", producto.Nombre_Producto),
                    new SqlParameter("@Descripcion", (object)producto.Descripcion_Producto ?? DBNull.Value),
                    new SqlParameter("@Precio", producto.Precio_Venta),
                    new SqlParameter("@Cantidad", producto.Cantidad_Disponible),
                    new SqlParameter("@Estado", producto.Estado_Producto)
                };

                DatabaseConnection.ExecuteNonQuery(query, parameters);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al insertar producto: {ex.Message}");
            }
        }

        // ==================== ACTUALIZAR PRODUCTO ====================
        public bool Actualizar(Producto producto)
        {
            try
            {
                string query = @"
                    UPDATE T_Producto
                    SET Nombre_Producto = @Nombre,
                        Descripcion_Producto = @Descripcion,
                        Precio_Venta = @Precio,
                        Cantidad_Disponible = @Cantidad,
                        Estado_Producto = @Estado
                    WHERE ID_Producto = @ID";

                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@ID", producto.ID_Producto),
                    new SqlParameter("@Nombre", producto.Nombre_Producto),
                    new SqlParameter("@Descripcion", (object)producto.Descripcion_Producto ?? DBNull.Value),
                    new SqlParameter("@Precio", producto.Precio_Venta),
                    new SqlParameter("@Cantidad", producto.Cantidad_Disponible),
                    new SqlParameter("@Estado", producto.Estado_Producto)
                };

                DatabaseConnection.ExecuteNonQuery(query, parameters);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al actualizar producto: {ex.Message}");
            }
        }

        // ==================== ELIMINAR PRODUCTO ====================
        public bool Eliminar(int idProducto)
        {
            try
            {
                string query = "DELETE FROM T_Producto WHERE ID_Producto = @ID";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@ID", idProducto)
                };

                DatabaseConnection.ExecuteNonQuery(query, parameters);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al eliminar producto: {ex.Message}");
            }
        }

        // ==================== VERIFICAR SI EXISTE PRODUCTO ====================
        public bool ExisteNombre(string nombre, int idProducto = 0)
        {
            string query = "SELECT COUNT(*) FROM T_Producto WHERE Nombre_Producto = @Nombre";

            if (idProducto > 0)
            {
                query += " AND ID_Producto != @ID";
            }

            SqlParameter[] parameters;

            if (idProducto > 0)
            {
                parameters = new SqlParameter[]
                {
                    new SqlParameter("@Nombre", nombre),
                    new SqlParameter("@ID", idProducto)
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