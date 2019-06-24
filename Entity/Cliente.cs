using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class Cliente : Personas
    {
        public String Fecha { get; set; }
        public String Hora { get; set; }
        public String Ciudades { get; set; }
        public String Ciudad_destino { get; set; }
       


        public Cliente(string nombre, string apellido, string identificacion, int edad, string ciudades, string ciudad_destino, string hora, string fecha) :
            base(nombre, apellido, identificacion,edad)
        {
            Nombre = nombre;
            Apellido = apellido;
            Identificacion = identificacion;
            Edad = edad;
            Ciudades = ciudades;
            Ciudad_destino = ciudad_destino;
            Hora = hora;
            Fecha = fecha;
        }



        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
