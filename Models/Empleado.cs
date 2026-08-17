using System;

namespace WalkiriaPapeleria.Models
{
    public class Empleado
    {
        public int ID_Empleado { get; set; }
        public string Cedula_Empleado { get; set; }
        public string Nombre_Empleado { get; set; }
        public string Apellido_Empleado { get; set; }
        public string Sexo { get; set; }
        public DateTime Fecha_Nacimiento { get; set; }
        public string Tipo_Sangre { get; set; }
        public DateTime Fecha_Registro { get; set; }

        // Propiedades adicionales
        public string Celular_Empleado { get; set; }
        public string Telefono_Extra { get; set; }
        public string Correo_Empleado { get; set; }
        public string Direccion_Empleado { get; set; }
        public bool Estatus_Empleado { get; set; }
        public int ID_Usuario { get; set; }
        public string Usuario { get; set; }
        public string Clave { get; set; }
        public int ID_Rol { get; set; }
        public string Nombre_Rol { get; set; }
        public bool Estado_Usuario { get; set; }

        public string NombreCompleto => $"{Nombre_Empleado} {Apellido_Empleado}";
        public string Edad
        {
            get
            {
                int age = DateTime.Now.Year - Fecha_Nacimiento.Year;
                if (DateTime.Now.DayOfYear < Fecha_Nacimiento.DayOfYear)
                    age--;
                return age.ToString();
            }
        }
    }
}