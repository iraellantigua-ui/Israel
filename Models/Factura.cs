using System;

namespace WalkiriaPapeleria.Models
{
    public class Factura
    {
        public int ID_Factura { get; set; }
        public string Numero_Factura { get; set; }
        public int? ID_Cliente { get; set; }  // Nullable para ventas sin cliente
        public int ID_Usuario { get; set; }
        public int ID_Metodo_Pago { get; set; }
        public DateTime Fecha_Factura { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Descuento { get; set; }
        public decimal ITBIS { get; set; }
        public decimal Total_Factura { get; set; }
        public bool Estado_Factura { get; set; }

        // Propiedades adicionales para mostrar
        public string NombreCliente { get; set; }
        public string NombreUsuario { get; set; }
        public string MetodoPago { get; set; }
    }
}
