using System;
using System.Data;
using System.Data.SqlClient;
using WalkiriaPapeleria.Models;
using System.Collections.Generic;

namespace WalkiriaPapeleria.DAO
{
    public class CierreCajaDAO
    {
        // ==================== OBTENER TODOS LOS CIERRES ====================
        public DataTable ObtenerTodos()
        {
            string query = @"
                SELECT 
                    cc.ID_Cierre_Caja,
                    cc.Fecha_Cierre,
                    t.Nombre_Turno,
                    cc.Fondo_Inicial,
                    cc.Cantidad_Facturas,
                    cc.Total_Efectivo,
                    cc.Total_Tarjeta,
                    cc.Total_Transferencia,
                    cc.Total_Ventas,
                    cc.Monto_Contado,
                    cc.Diferencia_Caja,
                    cc.Observacion,
                    cc.Estado_Cierre,
                    u.Usuario AS Supervisor,
                    e.Nombre_Empleado + ' ' + e.Apellido_Empleado AS Cajero
                FROM T_Cierre_Caja cc
                INNER JOIN T_Asignacion_Turno at ON cc.ID_Asignacion_Turno = at.ID_Asignacion_Turno
                INNER JOIN T_Turno t ON at.ID_Turno = t.ID_Turno
                INNER JOIN T_Usuarios u ON cc.ID_Supervisor = u.ID_Usuario
                INNER JOIN T_Usuarios u2 ON at.ID_Usuario = u2.ID_Usuario
                INNER JOIN T_Empleado e ON u2.ID_Empleado = e.ID_Empleado
                ORDER BY cc.Fecha_Cierre DESC";

            return DatabaseConnection.ExecuteQuery(query);
        }

        // ==================== OBTENER CIERRES POR FECHA ====================
        public DataTable ObtenerPorFecha(DateTime fecha)
        {
            string query = @"
                SELECT 
                    cc.ID_Cierre_Caja,
                    cc.Fecha_Cierre,
                    t.Nombre_Turno,
                    cc.Fondo_Inicial,
                    cc.Cantidad_Facturas,
                    cc.Total_Efectivo,
                    cc.Total_Tarjeta,
                    cc.Total_Transferencia,
                    cc.Total_Ventas,
                    cc.Monto_Contado,
                    cc.Diferencia_Caja,
                    cc.Observacion,
                    cc.Estado_Cierre,
                    u.Usuario AS Supervisor,
                    e.Nombre_Empleado + ' ' + e.Apellido_Empleado AS Cajero
                FROM T_Cierre_Caja cc
                INNER JOIN T_Asignacion_Turno at ON cc.ID_Asignacion_Turno = at.ID_Asignacion_Turno
                INNER JOIN T_Turno t ON at.ID_Turno = t.ID_Turno
                INNER JOIN T_Usuarios u ON cc.ID_Supervisor = u.ID_Usuario
                INNER JOIN T_Usuarios u2 ON at.ID_Usuario = u2.ID_Usuario
                INNER JOIN T_Empleado e ON u2.ID_Empleado = e.ID_Empleado
                WHERE CAST(cc.Fecha_Cierre AS DATE) = @Fecha
                ORDER BY cc.Fecha_Cierre DESC";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Fecha", fecha.Date)
            };

            return DatabaseConnection.ExecuteQuery(query, parameters);
        }

        // ==================== OBTENER ASIGNACIÓN POR CAJERO, FECHA Y TURNO ====================
        public DataTable ObtenerAsignacionPorCajeroFechaTurno(int idCajero, DateTime fecha, string turno)
        {
            string query = @"
                SELECT 
                    at.ID_Asignacion_Turno,
                    at.ID_Usuario,
                    at.ID_Turno,
                    at.Fecha_Asignacion,
                    at.Estado_Asignacion,
                    t.Nombre_Turno,
                    e.Nombre_Empleado + ' ' + e.Apellido_Empleado AS Cajero
                FROM T_Asignacion_Turno at
                INNER JOIN T_Turno t ON at.ID_Turno = t.ID_Turno
                INNER JOIN T_Usuarios u ON at.ID_Usuario = u.ID_Usuario
                INNER JOIN T_Empleado e ON u.ID_Empleado = e.ID_Empleado
                WHERE at.ID_Usuario = @IDCajero
                AND CAST(at.Fecha_Asignacion AS DATE) = @Fecha
                AND t.Nombre_Turno = @Turno
                AND at.Estado_Asignacion = 1";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@IDCajero", idCajero),
                new SqlParameter("@Fecha", fecha.Date),
                new SqlParameter("@Turno", turno)
            };

            return DatabaseConnection.ExecuteQuery(query, parameters);
        }

        // ==================== OBTENER VENTAS DEL TURNO ====================
        public DataTable ObtenerVentasTurno(int idAsignacionTurno)
        {
            string query = @"
                SELECT 
                    f.Numero_Factura,
                    f.Fecha_Factura,
                    ISNULL(c.Nombre_Cliente + ' ' + c.Apellido_Cliente, 'Cliente General') AS Cliente,
                    mp.Metodo_Pago,
                    f.Total_Factura
                FROM T_Factura f
                LEFT JOIN T_Cliente c ON f.ID_Cliente = c.ID_Cliente
                INNER JOIN T_Metodo_Pago mp ON f.ID_Metodo_pago = mp.ID_Metodo_Pago
                INNER JOIN T_Asignacion_Turno at ON f.ID_Usuario = at.ID_Usuario
                WHERE at.ID_Asignacion_Turno = @IDAsignacionTurno
                AND f.Fecha_Factura >= at.Fecha_Asignacion
                AND f.Estado_Factura = 1
                ORDER BY f.Fecha_Factura";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@IDAsignacionTurno", idAsignacionTurno)
            };

            return DatabaseConnection.ExecuteQuery(query, parameters);
        }

        // ==================== OBTENER TOTALES DEL TURNO ====================
        public decimal[] ObtenerTotalesTurno(int idAsignacionTurno)
        {
            string query = @"
                SELECT 
                    ISNULL(SUM(CASE WHEN mp.Metodo_Pago = 'EFECTIVO' THEN f.Total_Factura ELSE 0 END), 0) AS TotalEfectivo,
                    ISNULL(SUM(CASE WHEN mp.Metodo_Pago = 'TARJETA' THEN f.Total_Factura ELSE 0 END), 0) AS TotalTarjeta,
                    ISNULL(SUM(CASE WHEN mp.Metodo_Pago = 'TRANSFERENCIA' THEN f.Total_Factura ELSE 0 END), 0) AS TotalTransferencia,
                    ISNULL(SUM(f.Total_Factura), 0) AS TotalVentas,
                    COUNT(f.ID_Factura) AS CantidadFacturas
                FROM T_Factura f
                INNER JOIN T_Metodo_Pago mp ON f.ID_Metodo_pago = mp.ID_Metodo_Pago
                INNER JOIN T_Asignacion_Turno at ON f.ID_Usuario = at.ID_Usuario
                WHERE at.ID_Asignacion_Turno = @IDAsignacionTurno
                AND f.Fecha_Factura >= at.Fecha_Asignacion
                AND f.Estado_Factura = 1";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@IDAsignacionTurno", idAsignacionTurno)
            };

            DataTable result = DatabaseConnection.ExecuteQuery(query, parameters);

            if (result.Rows.Count > 0)
            {
                DataRow row = result.Rows[0];
                decimal[] totales = new decimal[5];
                totales[0] = Convert.ToDecimal(row["TotalEfectivo"]);      // Efectivo
                totales[1] = Convert.ToDecimal(row["TotalTarjeta"]);       // Tarjeta
                totales[2] = Convert.ToDecimal(row["TotalTransferencia"]); // Transferencia
                totales[3] = Convert.ToDecimal(row["TotalVentas"]);        // Total Ventas
                totales[4] = Convert.ToInt32(row["CantidadFacturas"]);     // Cantidad Facturas
                return totales;
            }

            return new decimal[5] { 0, 0, 0, 0, 0 };
        }

        // ==================== OBTENER CAJEROS ====================
        public DataTable ObtenerCajeros()
        {
            string query = @"
                SELECT 
                    u.ID_Usuario,
                    u.Usuario,
                    e.Nombre_Empleado + ' ' + e.Apellido_Empleado AS NombreCompleto
                FROM T_Usuarios u
                INNER JOIN T_Empleado e ON u.ID_Empleado = e.ID_Empleado
                INNER JOIN T_Roles r ON u.ID_Rol = r.ID_Rol
                WHERE r.Nombre_Rol = 'Cajero'
                AND u.Estado_Usuario = 1
                ORDER BY e.Nombre_Empleado, e.Apellido_Empleado";

            return DatabaseConnection.ExecuteQuery(query);
        }

        // ==================== OBTENER SUPERVISORES ====================
        public DataTable ObtenerSupervisores()
        {
            string query = @"
                SELECT 
                    u.ID_Usuario,
                    u.Usuario,
                    e.Nombre_Empleado + ' ' + e.Apellido_Empleado AS NombreCompleto
                FROM T_Usuarios u
                INNER JOIN T_Empleado e ON u.ID_Empleado = e.ID_Empleado
                INNER JOIN T_Roles r ON u.ID_Rol = r.ID_Rol
                WHERE r.Nombre_Rol IN ('Administrador', 'Supervisor')
                AND u.Estado_Usuario = 1
                ORDER BY e.Nombre_Empleado, e.Apellido_Empleado";

            return DatabaseConnection.ExecuteQuery(query);
        }

        // ==================== GUARDAR CIERRE DE CAJA ====================
        public bool GuardarCierre(CierreCaja cierre)
        {
            try
            {
                string query = @"
                    INSERT INTO T_Cierre_Caja 
                    (ID_Asignacion_Turno, ID_Supervisor, Fondo_Inicial, 
                     Cantidad_Facturas, Total_Efectivo, Total_Tarjeta, Total_Transferencia,
                     Total_Ventas, Monto_Contado, Diferencia_Caja, Observacion, Estado_Cierre)
                    VALUES 
                    (@IDAsignacionTurno, @IDSupervisor, @FondoInicial,
                     @CantidadFacturas, @TotalEfectivo, @TotalTarjeta, @TotalTransferencia,
                     @TotalVentas, @MontoContado, @DiferenciaCaja, @Observacion, @EstadoCierre)";

                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@IDAsignacionTurno", cierre.ID_Asignacion_Turno),
                    new SqlParameter("@IDSupervisor", cierre.ID_Supervisor),
                    new SqlParameter("@FondoInicial", cierre.Fondo_Inicial),
                    new SqlParameter("@CantidadFacturas", cierre.Cantidad_Facturas),
                    new SqlParameter("@TotalEfectivo", cierre.Total_Efectivo),
                    new SqlParameter("@TotalTarjeta", cierre.Total_Tarjeta),
                    new SqlParameter("@TotalTransferencia", cierre.Total_Transferencia),
                    new SqlParameter("@TotalVentas", cierre.Total_Ventas),
                    new SqlParameter("@MontoContado", cierre.Monto_Contado),
                    new SqlParameter("@DiferenciaCaja", (object)cierre.Diferencia_Caja ?? DBNull.Value),
                    new SqlParameter("@Observacion", (object)cierre.Observacion ?? DBNull.Value),
                    new SqlParameter("@EstadoCierre", cierre.Estado_Cierre)
                };

                DatabaseConnection.ExecuteNonQuery(query, parameters);

                // Actualizar estado de la asignación de turno
                string queryUpdate = @"
                    UPDATE T_Asignacion_Turno 
                    SET Estado_Asignacion = 0 
                    WHERE ID_Asignacion_Turno = @IDAsignacionTurno";

                SqlParameter[] parametersUpdate = new SqlParameter[]
                {
                    new SqlParameter("@IDAsignacionTurno", cierre.ID_Asignacion_Turno)
                };

                DatabaseConnection.ExecuteNonQuery(queryUpdate, parametersUpdate);

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al guardar cierre de caja: {ex.Message}");
            }
        }

        // ==================== VERIFICAR SI YA EXISTE CIERRE PARA EL TURNO ====================
        public bool ExisteCierre(int idAsignacionTurno)
        {
            string query = "SELECT COUNT(*) FROM T_Cierre_Caja WHERE ID_Asignacion_Turno = @IDAsignacionTurno";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@IDAsignacionTurno", idAsignacionTurno)
            };

            int count = Convert.ToInt32(DatabaseConnection.ExecuteScalar(query, parameters));
            return count > 0;
        }
    }
}