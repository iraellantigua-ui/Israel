using System;

namespace WalkiriaPapeleria.Models
{
    public class DetalleFactura
    {
        public int ID_Detalle { get; set; }
        public int ID_Factura { get; set; }
        public string Categoria { get; set; }  // "PRODUCTO" o "SERVICIO"
        public int? ID_Producto { get; set; }
        public int? ID_Servicio { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio_Unitario { get; set; }
        public decimal Descuento_Detalle { get; set; }
        public decimal Total_Detalle { get; set; }

        // Propiedades adicionales para mostrar en el grid
        public string NombreItem { get; set; }
        public string DescripcionItem { get; set; }
    }
}
