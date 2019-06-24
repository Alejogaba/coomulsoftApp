using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class Vehiculo
    {
        public string Imagen { get; set; }
        public String Codigo { get; set; }
        public String Placa_Vehiculo { get; set; }
        public String Anio_Modelo { get; set; }
        public String Tipo_vehiculo { get; set; }
        public int Capacidad_pasajeros { get; set; }
        public string Capacidad_maletero { get; set; }
        public double Consumo_gasolina_km { get; set; }
        public String Cedula_dueño { get; set; }

        public Vehiculo(string imagen, string codigo, string placa_Vehiculo, string anio_Modelo, string tipo_vehiculo, int capacidad_pasajeros, string capacidad_maletero, double consumo_gasolina_km, string cedula_dueño)
        {
            Imagen = imagen;
            Codigo = codigo;
            Placa_Vehiculo = placa_Vehiculo;
            Anio_Modelo = anio_Modelo;
            Tipo_vehiculo = tipo_vehiculo;
            Capacidad_pasajeros = capacidad_pasajeros;
            Capacidad_maletero = capacidad_maletero;
            Consumo_gasolina_km = consumo_gasolina_km;
            Cedula_dueño = cedula_dueño;
        }

        public Vehiculo()
        {
        }
    }
}
