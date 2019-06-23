using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class Conductor : Personas
    {
        
        public String Telefono { get; set; }

        public Conductor()
        {
        }

        public Conductor(string nombre, string apellido, string identificacion, int edad, string telefono) : 
            base(nombre, apellido, identificacion,edad)
        {
            Nombre = nombre;
            Apellido = apellido;
            Identificacion = identificacion;
            Edad = edad;
            Telefono = telefono;
        }

       
    }
}
