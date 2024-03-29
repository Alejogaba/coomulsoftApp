﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class Viaje
    {
        public int Codigo_viaje { get; set; }
        public String Cedula_conductor { get; set; }
        public string Codigo_vehiculo { get; set; }
        public DateTime Fecha_salida { get; set; }
  
        public DateTime Hora_salida { get; set; }

        public String Ciudad_origen { get; set; }
        public String Ciudad_destino { get; set; }

        public Viaje(int codigo_viaje, string cedula_conductor, string cod_vehiculo, DateTime fecha_salida, DateTime hora_salida,  string ciudad_origen, string ciudad_destino)
        {
            Codigo_viaje = codigo_viaje;
            Cedula_conductor = cedula_conductor;
            Codigo_vehiculo = cod_vehiculo;
            Fecha_salida = fecha_salida;
         
            Hora_salida = hora_salida;
          
            Ciudad_origen = ciudad_origen;
            Ciudad_destino = ciudad_destino;
        }

        public Viaje()
        {
        }

        public int Generar_codigo_viaje()
        {
            Random random = new Random();
            for (int i = 0; i < 2; i++)
            {
                Codigo_viaje = random.Next(100, 999);
                
            }
            return Codigo_viaje;
        }
        
    }
}
