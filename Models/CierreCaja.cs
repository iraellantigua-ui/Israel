using System;

namespace WalkiriaPapeleria.Models
{
    public class CierreCaja
    {
        public int ID_Cierre_Caja { get; set; }
        public int ID_Asignacion_Turno { get; set; }
        public int ID_Supervisor { get; set; }
        public DateTime Fecha_Cierre { get; set; }
        public decimal Fondo_Inicial { get; set; }
        public int Cantidad_Facturas { get; set; }
        public decimal Total_Efectivo { get; set; }
        public decimal Total_Tarjeta { get; set; }
        public decimal Total_Transferencia { get; set; }
        public decimal Total_Ventas { get; set; }
        public decimal Monto_Contado { get; set; }
        public decimal? Diferencia_Caja { get; set; }
        public string Observacion { get; set; }
        public bool Estado_Cierre { get; set; }
        public DateTime Fecha_Registro { get; set; }

        // Propiedades adicionales
        public string NombreSupervisor { get; set; }
        public string NombreTurno { get; set; }
        public string FechaTurno { get; set; }
    }
}