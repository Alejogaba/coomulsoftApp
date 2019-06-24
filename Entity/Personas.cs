using System;

namespace Entity
{
    public class Personas

    {
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public String Identificacion { get; set; }
        public string Telefono { get; set; }

        public Personas()
        {

        }

        public Personas(string nombre, string apellido, string identificacion, string telefono)
        {
            Nombre = nombre;
            Apellido = apellido;
            Identificacion = identificacion;
            Telefono = telefono;
        }
        public string Nombre_Completo()
        {
            return Nombre + Apellido;
        }
    }
}
