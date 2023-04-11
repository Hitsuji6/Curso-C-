using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raio
{
    public class Calculos
    {
        static double Pi = 3.14;
        public double Raio { get; set; }
        public double Resultado { get; set; }

        public void Circunferencia(double r, double resultado)
        {
            Raio = r;
            Resultado = resultado;
            resultado = 2 * Pi * r;
        }

        public void Volume(double r, double resultado)
        {
            Raio = r;
            Resultado = resultado;
            resultado = 4 / 3 * Pi * Math.Pow(r, 3);

        }
    }
}
