using System;

namespace WalkiriaPapeleria.Models
{
    public class Servicio
    {
        public int ID_Servicio { get; set; }
        public string Nombre_Servicio { get; set; }
        public string Descripcion_Servicio { get; set; }
        public decimal Precio_Servicio { get; set; }
        public bool Estado_Servicio { get; set; }
        public DateTime Fecha_Registro { get; set; }

        // Propiedad para mostrar el estado como texto
        public string EstadoTexto => Estado_Servicio ? "Disponible" : "No Disponible";
    }
}