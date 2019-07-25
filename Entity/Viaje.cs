using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class Viaje
    {
        public int Codigo_viaje { get; set; }
        public String Cedula_conductor { get; set; }
        public string Cod_vehiculo { get; set; }
        public DateTime Fecha_salida { get; set; }
        public DateTime Fecha_llegada { get; set; }
        public DateTime Hora_salida { get; set; }
        public DateTime Hora_llegada { get; set; }
        public String Ciudad_origen { get; set; }
        public String Ciudad_destino { get; set; }

        public Viaje(int codigo_viaje, string cedula_conductor, string cod_vehiculo, DateTime fecha_salida, DateTime fecha_llegada, DateTime hora_salida, DateTime hora_llegada, string ciudad_origen, string ciudad_destino)
        {
            Codigo_viaje = codigo_viaje;
            Cedula_conductor = cedula_conductor;
            Cod_vehiculo = cod_vehiculo;
            Fecha_salida = fecha_salida;
            Fecha_llegada = fecha_llegada;
            Hora_salida = hora_salida;
            Hora_llegada = hora_llegada;
            Ciudad_origen = ciudad_origen;
            Ciudad_destino = ciudad_destino;
        }

        public Viaje()
        {
        }

        public void Generar_codigo_viaje()
        {
            Random random = new Random();
            Codigo_viaje = random.Next(10000,99999);
        }
        
    }
}
