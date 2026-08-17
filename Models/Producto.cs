using System;

namespace WalkiriaPapeleria.Models
{
    public class Producto
    {
        public int ID_Producto { get; set; }
        public string Nombre_Producto { get; set; }
        public string Descripcion_Producto { get; set; }
        public decimal Precio_Venta { get; set; }
        public bool Estado_Producto { get; set; }
        public int Cantidad_Disponible { get; set; }
        public DateTime Fecha_Registro { get; set; }

        // Propiedad para mostrar el estado como texto
        public string EstadoTexto => Estado_Producto ? "Disponible" : "Agotado";
    }
}