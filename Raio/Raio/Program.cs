using Raio;
using System.Collections.Specialized;

namespace Raio
{
    public class Program
    {
        static void Main(string[] args)
        {

            Calculos calc = new Calculos();

            Console.WriteLine("Entre com o valor do Raio: ");
            double Raio = double.Parse(Console.ReadLine());

            double circ = calc.Circunferencia(Raio);
            double volume = calc.Volume(Raio);

            Console.WriteLine($"O valor da Circunferencia é: {circ}");
            Console.WriteLine($"O valor de Pi é: {calc.Pi}");
            Console.WriteLine($"o valor do Volume é: {volume}");
        }
    }
}