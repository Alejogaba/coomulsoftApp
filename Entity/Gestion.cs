using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    class Gestion
    {
        public double Salario { get; set; }
        public double Seguro_contra_daños { get {return this.Seguro_contra_daños = Salario * 0.05; } set { } }
        public double aux_combustible { get; set; }
        public int Horas_extras_trabajadas { get; set; }

        public Gestion(double salario, double seguro_contra_daños, double aux_combustible, int horas_extras_trabajadas)
        {
            Salario = salario;
            Seguro_contra_daños = seguro_contra_daños;
            this.aux_combustible = aux_combustible;
            Horas_extras_trabajadas = horas_extras_trabajadas;
        }

        public double Total_a_pagar()
        {
            return Salario+aux_combustible+(Horas_extras_trabajadas*0.02)-Seguro_contra_daños;
        }
    }
}
