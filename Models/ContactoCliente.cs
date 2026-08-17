using System;

namespace WalkiriaPapeleria.Models
{
    public class ContactoCliente
    {
        public int ID_Contacto_Cliente { get; set; }
        public int ID_Cliente { get; set; }
        public string Telefono_Cliente { get; set; }
        public string Correo_Cliente { get; set; }
        public string Direccion_Cliente { get; set; }
        public DateTime Registro_Cliente { get; set; }
    }
}