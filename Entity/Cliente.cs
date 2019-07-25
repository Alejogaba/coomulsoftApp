using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class Cliente : Personas
    {
        public int Codigo_viaje { get; set; }



        public Cliente(int codigo,string nombre, string apellido, string identificacion, string telefono,string direccion)
        {
            Nombre = nombre;
            Apellido = apellido;
            Telefono = telefono;
            Identificacion = identificacion;
            Codigo_viaje = codigo;
            Direccion = direccion;
        
        }

        public Cliente()
        {
        }
    }
}
