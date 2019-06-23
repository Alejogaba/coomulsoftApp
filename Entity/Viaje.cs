using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class Viaje
    {
        public String Fecha { get; set; }
        public String Hora { get; set; }
        public String Hora_llegada { get; set; }
        public String Ciudades { get; set; }
        public String Ciudad_destino { get; set; }
        public decimal Valor { get; set; }
        public String Nombre_Conductor { get; set; }

        public Viaje(string ciudades, string ciudad_destino, string fecha, string hora,string hora_llegada, decimal valor, string nombre_conductor)
        {
            Fecha = fecha;
            Hora = hora;
            Hora_llegada = hora_llegada;
            Ciudades = ciudades;
            Ciudad_destino = ciudad_destino;
            Valor = valor;
            Nombre_Conductor = nombre_conductor;
        }
        
        
    }
}
