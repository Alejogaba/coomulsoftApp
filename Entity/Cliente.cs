using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class Cliente : Personas
    {
        public int Codigo_viaje { get; set; }
        public double Valor_A_Pagar { get; set; }



        public Cliente(int codigo,string nombre, string apellido, string identificacion, string telefono, double valor)
        {
            Nombre = nombre;
            Apellido = apellido;
            Telefono = telefono;
            Identificacion = identificacion;
            Codigo_viaje = codigo;
            Valor_A_Pagar = valor;
        }



       
    }
}
