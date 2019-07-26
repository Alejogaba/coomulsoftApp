using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class Vehiculo
    {
        public byte[] Imagen { get; set; }
        public String Codigo { get; set; }
        public String Modelo { get; set; }
        public String Placa_Vehiculo { get; set; }
        public String Anio_Modelo { get; set; }
        public String Tipo_vehiculo { get; set; }
        public int Capacidad_pasajeros { get; set; }
        public float Capacidad_maletero { get; set; }
        
      

        public Vehiculo(byte[] imagen, string codigo,string nombre_modelo, string placa_Vehiculo, string anio_Modelo, string tipo_vehiculo, int capacidad_pasajeros, float capacidad_maletero)
        {
            Imagen = imagen;
            Codigo = codigo;
            Modelo = nombre_modelo;
            Placa_Vehiculo = placa_Vehiculo;
            Anio_Modelo = anio_Modelo;
            Tipo_vehiculo = tipo_vehiculo;
            Capacidad_pasajeros = capacidad_pasajeros;
            Capacidad_maletero = capacidad_maletero;
        
            
        }

        public Vehiculo()
        {
        }
    }
}
