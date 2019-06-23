using System;

namespace Entity
{
    public class Personas

    {
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public String NombreCompleto {
            get { return this.NombreCompleto = Nombre + Apellido; }set { } }
        public String Identificacion { get; set; }
        public int Edad { get; set; }

        public Personas()
        {

        }

        public Personas(string nombre, string apellido, string identificacion, int edad)
        {
            Nombre = nombre;
            Apellido = apellido;
            Identificacion = identificacion;
            Edad = edad;
        }
    }
}
