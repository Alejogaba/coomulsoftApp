using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class Vehiculo
    {
        public String Referencia { get; set; }
        public String Placa_Vehiculo { get; set; }
        public String Anio_Modelo { get; set; }
        public String Tipo_vehiculo { get; set; }
        public String Nombre_buscador { get; set; }

        public Vehiculo(string referencia, string placa_Vehiculo, string anio_Modelo, string tipo_vehiculo,string nombre_buscador)
        {
            Referencia = referencia;
            Placa_Vehiculo = placa_Vehiculo;
            Anio_Modelo = anio_Modelo;
            Tipo_vehiculo = tipo_vehiculo;
            Nombre_buscador = nombre_buscador;
        }

        public Vehiculo()
        {
        }
    }
}
