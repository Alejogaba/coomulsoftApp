using System;

namespace Entity
{
    public class Personas

    {
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public String Identificacion { get; set; }
        public string Telefono { get; set; }

        public string Direccion { get; set; }

        public Personas()
        {

        }

        public Personas(string nombre, string apellido, string identificacion, string telefono, string direccion)
        {
            Nombre = nombre;
            Apellido = apellido;
            Identificacion = identificacion;
            Telefono = telefono;
            Direccion = direccion;
        }

        public string Nombre_Completo()
        {
            return Nombre + Apellido;
        }
    }
}
