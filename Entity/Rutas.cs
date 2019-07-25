using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
   public class Rutas
    {
        public string Ciudad_Origen { get; set; }
        public string Dpto_Origen { get; set; }
        public string Ciudad_Destino { get; set; }
        public string Dpto_Destino { get; set; }
        public double Tarifa { get; set; }

        public Rutas(string ciudad_Origen, string dpto_Origen, string ciudad_Destino, string dpto_Destino, double tarifa)
        {
            Ciudad_Origen = ciudad_Origen;
            Dpto_Origen = dpto_Origen;
            Ciudad_Destino = ciudad_Destino;
            Dpto_Destino = dpto_Destino;
            Tarifa = tarifa;
        }

        public Rutas()
        {
        }

      


        public void Invertir_origen_destino()
        {
            string aux, aux2;
            aux = Ciudad_Destino;
            Ciudad_Destino = Ciudad_Origen;
            Ciudad_Origen = aux;
            aux2 = Dpto_Destino;
            Dpto_Destino = Dpto_Origen;
            Dpto_Origen = aux2;
        }
    }
}
