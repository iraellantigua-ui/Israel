using System;
using System.Data;
using System.Data.SqlClient;

namespace WalkiriaPapeleria.DAO
{
    public class ReinicioDAO
    {
        // ==================== REINICIAR TODAS LAS TABLAS ====================
        public bool ReiniciarSistema()
        {
            try
            {
                // 1. Desactivar restricciones de clave foránea
                EjecutarComando("EXEC sp_MSforeachtable 'ALTER TABLE ? NOCHECK CONSTRAINT ALL'");

                // 2. Eliminar datos de tablas con FK (dependientes)
                EjecutarComando("DELETE FROM T_Detalle_Factura");
                EjecutarComando("DELETE FROM T_Factura");
                EjecutarComando("DELETE FROM T_Asignacion_Turno");
                EjecutarComando("DELETE FROM T_Cierre_Caja");
                EjecutarComando("DELETE FROM T_Contacto_Cliente");

                // 3. Eliminar clientes (excepto los que tengan facturas asociadas)
                EjecutarComando("DELETE FROM T_Cliente WHERE ID_Cliente NOT IN (SELECT ID_Cliente FROM T_Factura WHERE ID_Cliente IS NOT NULL)");

                // 4. Eliminar empleados (excepto el administrador Walkiria - ID_Empleado = 1)
                EjecutarComando("DELETE FROM T_Contacto_Empleado WHERE ID_Empleado != 1");
                EjecutarComando("DELETE FROM T_Estatus_Empleado WHERE ID_Empleado != 1");
                EjecutarComando("DELETE FROM T_Usuarios WHERE ID_Empleado != 1");
                EjecutarComando("DELETE FROM T_Empleado WHERE ID_Empleado != 1");

                // 5. Eliminar productos y servicios
                EjecutarComando("DELETE FROM T_Producto");
                EjecutarComando("DELETE FROM T_Servicio");

                // 6. Reactivar restricciones de clave foránea
                EjecutarComando("EXEC sp_MSforeachtable 'ALTER TABLE ? CHECK CONSTRAINT ALL'");

                // 7. Reiniciar contadores IDENTITY
                ReiniciarContadores();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al reiniciar sistema: {ex.Message}");
            }
        }

        // ==================== EJECUTAR COMANDO SQL ====================
        private void EjecutarComando(string query)
        {
            using (SqlCommand command = new SqlCommand(query, DatabaseConnection.GetConnection()))
            {
                command.ExecuteNonQuery();
            }
            DatabaseConnection.CloseConnection();
        }

        // ==================== REINICIAR CONTADORES IDENTITY ====================
        private void ReiniciarContadores()
        {
            string[] tablas = new string[]
            {
                "T_Detalle_Factura",
                "T_Factura",
                "T_Asignacion_Turno",
                "T_Cierre_Caja",
                "T_Contacto_Cliente",
                "T_Cliente",
                "T_Contacto_Empleado",
                "T_Estatus_Empleado",
                "T_Usuarios",
                "T_Empleado",
                "T_Producto",
                "T_Servicio"
            };

            foreach (string tabla in tablas)
            {
                try
                {
                    string query = $"DBCC CHECKIDENT ('{tabla}', RESEED, 0)";
                    EjecutarComando(query);
                }
                catch
                {
                    // Si la tabla no tiene IDENTITY, ignorar
                }
            }
        }

        // ==================== VERIFICAR SI HAY DATOS PARA REINICIAR ====================
        public bool HayDatosParaReiniciar()
        {
            try
            {
                string query = @"
                    SELECT 
                        (SELECT COUNT(*) FROM T_Factura) +
                        (SELECT COUNT(*) FROM T_Cliente WHERE ID_Cliente > 20) +
                        (SELECT COUNT(*) FROM T_Producto WHERE ID_Producto > 25) +
                        (SELECT COUNT(*) FROM T_Servicio WHERE ID_Servicio > 15) +
                        (SELECT COUNT(*) FROM T_Empleado WHERE ID_Empleado > 1) AS TotalRegistros";

                DataTable result = DatabaseConnection.ExecuteQuery(query);
                if (result.Rows.Count > 0)
                {
                    int total = Convert.ToInt32(result.Rows[0]["TotalRegistros"]);
                    return total > 0;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
    }
}