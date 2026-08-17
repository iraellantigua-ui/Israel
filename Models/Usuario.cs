using System;

namespace WalkiriaPapeleria.Models
{
    public class Usuario
    {
        public int ID_Usuario { get; set; }
        public int ID_Empleado { get; set; }
        public int ID_Rol { get; set; }
        public string UsuarioNombre { get; set; }
        public string Clave { get; set; }
        public bool Estado_Usuario { get; set; }
        public DateTime Fecha_Registro { get; set; }
        public string NombreEmpleado { get; set; }
        public string ApellidoEmpleado { get; set; }
        public string RolNombre { get; set; }

        public string NombreCompleto => $"{NombreEmpleado} {ApellidoEmpleado}";
    }
}