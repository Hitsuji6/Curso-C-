using Cod;
using System.Collections.Specialized;

namespace Aplication
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com um numero:");
            var n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com outro numero");
            var n2 = double.Parse(Console.ReadLine());


            Calculos calculos2 = new Calculos(n1, n2);
            Console.WriteLine($"O valor da soma é: {calculos2.Soma}");


            Console.WriteLine("----------------------------------");
            Console.WriteLine("baskara");
            Console.WriteLine("Entre com o valor de A: ");
            var a = double.Parse(Console.ReadLine()); 
            Console.WriteLine("Entre com o valor de B: ");
            var b = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o valor de C: ");
            var c = double.Parse(Console.ReadLine());

            Calculos _calculos = new Calculos(a, b, c);
            Console.WriteLine($"o valor de X1 é: {_calculos.X1} & o valor de X2 é: {_calculos.X2}");
            Console.ReadKey();
        }

    }
}