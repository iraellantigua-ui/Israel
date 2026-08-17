using System;

namespace WalkiriaPapeleria.Models
{
    public class Cliente
    {
        public int ID_Cliente { get; set; }
        public string Cedula_Cliente { get; set; }
        public string Nombre_Cliente { get; set; }
        public string Apellido_Cliente { get; set; }
        public DateTime Fecha_Registro_Cliente { get; set; }

        // Propiedad calculada (solo lectura)
        public string NombreCompleto => $"{Nombre_Cliente} {Apellido_Cliente}";
    }
}
