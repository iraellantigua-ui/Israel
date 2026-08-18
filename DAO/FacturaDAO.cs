using System;
using System.Data;
using System.Data.SqlClient;
using WalkiriaPapeleria.Models;
using System.Collections.Generic;

namespace WalkiriaPapeleria.DAO
{
    public class FacturaDAO
    {
        // ==================== OBTENER TODAS LAS FACTURAS ====================
        public DataTable ObtenerTodas()
        {
            string query = @"
                SELECT 
                    f.ID_Factura,
                    f.Numero_Factura,
                    f.Fecha_Factura,
                    ISNULL(c.Nombre_Cliente + ' ' + c.Apellido_Cliente, 'Cliente General') AS Cliente,
                    u.Usuario AS Usuario,
                    mp.Metodo_Pago,
                    f.Subtotal,
                    f.Descuento,
                    f.ITBIS,
                    f.Total_Factura,
                    f.Estado_Factura
                FROM T_Factura f
                LEFT JOIN T_Cliente c ON f.ID_Cliente = c.ID_Cliente
                INNER JOIN T_Usuarios u ON f.ID_Usuario = u.ID_Usuario
                INNER JOIN T_Metodo_Pago mp ON f.ID_Metodo_pago = mp.ID_Metodo_Pago
                ORDER BY f.Fecha_Factura DESC";

            return DatabaseConnection.ExecuteQuery(query);
        }

        // ==================== OBTENER FACTURAS POR RANGO DE FECHAS ====================
        public DataTable ObtenerPorFechas(DateTime fechaInicio, DateTime fechaFin)
        {
            string query = @"
                SELECT 
                    f.ID_Factura,
                    f.Numero_Factura,
                    f.Fecha_Factura,
                    ISNULL(c.Nombre_Cliente + ' ' + c.Apellido_Cliente, 'Cliente General') AS Cliente,
                    u.Usuario AS Usuario,
                    mp.Metodo_Pago,
                    f.Subtotal,
                    f.Descuento,
                    f.ITBIS,
                    f.Total_Factura,
                    f.Estado_Factura
                FROM T_Factura f
                LEFT JOIN T_Cliente c ON f.ID_Cliente = c.ID_Cliente
                INNER JOIN T_Usuarios u ON f.ID_Usuario = u.ID_Usuario
                INNER JOIN T_Metodo_Pago mp ON f.ID_Metodo_pago = mp.ID_Metodo_Pago
                WHERE f.Fecha_Factura >= @FechaInicio AND f.Fecha_Factura <= @FechaFin
                ORDER BY f.Fecha_Factura DESC";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@FechaInicio", fechaInicio),
                new SqlParameter("@FechaFin", fechaFin)
            };

            return DatabaseConnection.ExecuteQuery(query, parameters);
        }

        // ==================== OBTENER FACTURA POR ID ====================
        public DataTable ObtenerPorID(int idFactura)
        {
            string query = @"
                SELECT 
                    f.ID_Factura,
                    f.Numero_Factura,
                    f.Fecha_Factura,
                    f.ID_Cliente,
                    ISNULL(c.Nombre_Cliente + ' ' + c.Apellido_Cliente, 'Cliente General') AS Cliente,
                    u.Usuario AS Usuario,
                    mp.Metodo_Pago,
                    f.Subtotal,
                    f.Descuento,
                    f.ITBIS,
                    f.Total_Factura,
                    f.Estado_Factura
                FROM T_Factura f
                LEFT JOIN T_Cliente c ON f.ID_Cliente = c.ID_Cliente
                INNER JOIN T_Usuarios u ON f.ID_Usuario = u.ID_Usuario
                INNER JOIN T_Metodo_Pago mp ON f.ID_Metodo_pago = mp.ID_Metodo_Pago
                WHERE f.ID_Factura = @IDFactura";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@IDFactura", idFactura)
            };

            return DatabaseConnection.ExecuteQuery(query, parameters);
        }

        // ==================== OBTENER DETALLE DE FACTURA ====================
        public DataTable ObtenerDetalle(int idFactura)
        {
            string query = @"
                SELECT 
                    df.ID_Detalle,
                    df.Categoria,
                    CASE 
                        WHEN df.Categoria = 'PRODUCTO' THEN p.Nombre_Producto
                        WHEN df.Categoria = 'SERVICIO' THEN s.Nombre_Servicio
                    END AS NombreItem,
                    df.Cantidad,
                    df.Precio_Unitario,
                    df.Descuento_Detalle,
                    df.Total_Detalle
                FROM T_Detalle_Factura df
                LEFT JOIN T_Producto p ON df.ID_Producto = p.ID_Producto
                LEFT JOIN T_Servicio s ON df.ID_Servicio = s.ID_Servicio
                WHERE df.ID_Factura = @IDFactura";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@IDFactura", idFactura)
            };

            return DatabaseConnection.ExecuteQuery(query, parameters);
        }

        // ==================== OBTENER NÚMERO DE FACTURA ====================
        public string ObtenerNumeroFactura()
        {
            string query = "SELECT COUNT(*) FROM T_Factura";
            int count = Convert.ToInt32(DatabaseConnection.ExecuteScalar(query));
            string numero = (count + 1).ToString("D8"); // Formato: 00000001
            return $"FAC-{DateTime.Now.Year}-{numero}";
        }

        // ==================== GUARDAR FACTURA COMPLETA ====================
        public int GuardarFactura(Factura factura, List<DetalleFactura> detalles)
        {
            try
            {
                // 1. Insertar la factura
                string queryFactura = @"
                    INSERT INTO T_Factura 
                    (Numero_Factura, ID_Cliente, ID_Usuario, ID_Metodo_pago, 
                     Subtotal, Descuento, ITBIS, Total_Factura, Estado_Factura)
                    VALUES 
                    (@Numero, @IDCliente, @IDUsuario, @IDMetodoPago,
                     @Subtotal, @Descuento, @ITBIS, @Total, @Estado);
                    SELECT SCOPE_IDENTITY();";

                SqlParameter[] parametersFactura = new SqlParameter[]
                {
                    new SqlParameter("@Numero", factura.Numero_Factura),
                    new SqlParameter("@IDCliente", (object)factura.ID_Cliente ?? DBNull.Value),
                    new SqlParameter("@IDUsuario", factura.ID_Usuario),
                    new SqlParameter("@IDMetodoPago", factura.ID_Metodo_Pago),
                    new SqlParameter("@Subtotal", factura.Subtotal),
                    new SqlParameter("@Descuento", factura.Descuento),
                    new SqlParameter("@ITBIS", factura.ITBIS),
                    new SqlParameter("@Total", factura.Total_Factura),
                    new SqlParameter("@Estado", factura.Estado_Factura)
                };

                // Ejecutar y obtener el ID de la factura
                object result = DatabaseConnection.ExecuteScalar(queryFactura, parametersFactura);
                int idFactura = Convert.ToInt32(result);

                // 2. Insertar los detalles
                foreach (var detalle in detalles)
                {
                    string queryDetalle = @"
                        INSERT INTO T_Detalle_Factura 
                        (ID_Factura, Categoria, ID_Producto, ID_Servicio, 
                         Cantidad, Precio_Unitario, Descuento_Detalle, Total_Detalle)
                        VALUES 
                        (@IDFactura, @Categoria, @IDProducto, @IDServicio,
                         @Cantidad, @PrecioUnitario, @Descuento, @TotalDetalle)";

                    SqlParameter[] parametersDetalle = new SqlParameter[]
                    {
                        new SqlParameter("@IDFactura", idFactura),
                        new SqlParameter("@Categoria", detalle.Categoria),
                        new SqlParameter("@IDProducto", (object)detalle.ID_Producto ?? DBNull.Value),
                        new SqlParameter("@IDServicio", (object)detalle.ID_Servicio ?? DBNull.Value),
                        new SqlParameter("@Cantidad", detalle.Cantidad),
                        new SqlParameter("@PrecioUnitario", detalle.Precio_Unitario),
                        new SqlParameter("@Descuento", detalle.Descuento_Detalle),
                        new SqlParameter("@TotalDetalle", detalle.Total_Detalle)
                    };

                    DatabaseConnection.ExecuteNonQuery(queryDetalle, parametersDetalle);

                    // 3. Actualizar stock del producto (si es producto)
                    if (detalle.Categoria == "PRODUCTO" && detalle.ID_Producto.HasValue)
                    {
                        string queryStock = @"
                            UPDATE T_Producto 
                            SET Cantidad_Disponible = Cantidad_Disponible - @Cantidad
                            WHERE ID_Producto = @IDProducto";

                        SqlParameter[] parametersStock = new SqlParameter[]
                        {
                            new SqlParameter("@Cantidad", detalle.Cantidad),
                            new SqlParameter("@IDProducto", detalle.ID_Producto.Value)
                        };

                        DatabaseConnection.ExecuteNonQuery(queryStock, parametersStock);
                    }
                }

                return idFactura;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al guardar factura: {ex.Message}");
            }
        }

        // ==================== ANULAR FACTURA ====================
        public bool AnularFactura(int idFactura)
        {
            try
            {
                // Obtener los detalles para devolver el stock
                string queryDetalles = @"
                    SELECT ID_Producto, Cantidad, Categoria 
                    FROM T_Detalle_Factura 
                    WHERE ID_Factura = @IDFactura AND Categoria = 'PRODUCTO'";

                SqlParameter[] parametersDetalles = new SqlParameter[]
                {
                    new SqlParameter("@IDFactura", idFactura)
                };

                DataTable detalles = DatabaseConnection.ExecuteQuery(queryDetalles, parametersDetalles);

                // Devolver stock
                foreach (DataRow row in detalles.Rows)
                {
                    if (row["ID_Producto"] != DBNull.Value)
                    {
                        int idProducto = Convert.ToInt32(row["ID_Producto"]);
                        int cantidad = Convert.ToInt32(row["Cantidad"]);

                        string queryStock = @"
                            UPDATE T_Producto 
                            SET Cantidad_Disponible = Cantidad_Disponible + @Cantidad
                            WHERE ID_Producto = @IDProducto";

                        SqlParameter[] parametersStock = new SqlParameter[]
                        {
                            new SqlParameter("@Cantidad", cantidad),
                            new SqlParameter("@IDProducto", idProducto)
                        };

                        DatabaseConnection.ExecuteNonQuery(queryStock, parametersStock);
                    }
                }

                // Anular la factura
                string query = "UPDATE T_Factura SET Estado_Factura = 0 WHERE ID_Factura = @IDFactura";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@IDFactura", idFactura)
                };

                DatabaseConnection.ExecuteNonQuery(query, parameters);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al anular factura: {ex.Message}");
            }
        }
    }
}