using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raio
{
    public class Calculos
    {
        public double Pi = 3.14;

        public double Circunferencia(double r)
        {
            return 2 * Pi * r;
        }

        public double Volume(double r)
        {
            return 4 / 3 * Pi * Math.Pow(r,3);
        }
        //public Circunferencia(double r, double resultado)
        //{
        //    Raio = r;
        //    Resultado = resultado;
        //    resultado = 2 * Pi * r;
        //}

        //public Volume(double r, double resultado)
        //{
        //    Raio = r;
        //    Resultado = resultado;
        //    resultado = 4 / 3 * Pi * Math.Pow(r, 3);

        //}
    }
}
