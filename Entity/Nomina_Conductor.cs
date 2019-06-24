using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class Nomina_Conductor
    { 
        public double Sueldo_base { get; set; }
        public double Salario { get; set; }
        public double Seguro_contra_daños { get; set; }
        public double aux_combustible { get; set; }
        public double Valor_viaje_extra { get; set; }
        public int Viaje_extra { get; set; }


        public Nomina_Conductor(double sueldo_base, double seguro_contra_daños, double valor_viaje_extra, int viaje_extra)
        {
            Sueldo_base = sueldo_base;
            Seguro_contra_daños = seguro_contra_daños;
            Valor_viaje_extra = valor_viaje_extra;
            Viaje_extra = viaje_extra;
        }

        public void Calcular_aux_combustible()
        {
            Vehiculo vehiculo = new Vehiculo();
            Rutas rutas = new Rutas();
            aux_combustible = rutas.Kilometros * vehiculo.Consumo_gasolina_km;
        }

        public void Calcular_Salario()
        {
            Salario = Sueldo_base + (Viaje_extra * Valor_viaje_extra) + (aux_combustible) - Seguro_contra_daños;
        }
    }
}
