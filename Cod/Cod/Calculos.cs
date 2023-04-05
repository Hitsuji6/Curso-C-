using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cod
{
    public class Calculos
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public double Delta { get; set; }
        public double X1 { get; set; }
        public double X2 { get; set; }

        public double N1 { get; set; }
        public double N2 { get; set; }
        public double Soma { get; set; }

        public Calculos(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
            Delta = Math.Pow(b, 2) - (4 * a * c); ;
            X1 = (-b + Math.Sqrt(Delta)) / (2 * a);
            X2 = (-b - Math.Sqrt(Delta)) / (2 * a);
        }

        public Calculos(double n1, double n2)
        {
            N1 = n1;
            N2 = n2;
            Soma = n1 + n2;
        }

        

    }
}
