using System;

namespace WalkiriaPapeleria.Models
{
    public class ContactoEmpleado
    {
        public int ID_Contacto { get; set; }
        public int ID_Empleado { get; set; }
        public string Celular_Empleado { get; set; }
        public string Telefono_Extra { get; set; }
        public string Correo_Empleado { get; set; }
        public string Direccion_Empleado { get; set; }
        public DateTime F_Registro_Contacto { get; set; }
    }
}