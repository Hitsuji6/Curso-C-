using Raio;
using System.Collections.Specialized;

namespace Raio
{
    public class Program
    {
        static double Pi = 3.14;
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o valor do Raio: ");
            var Raio = double.Parse(Console.ReadLine());

            
            Calculos _circunferencia = new Calculos();
            Calculos _volume = new Calculos();
            Console.WriteLine($"O valor da Circunferencia é: {_circunferencia.Resultado}");
            Console.WriteLine($"O valor de Pi é: {Pi}");
            Console.WriteLine($"o valor do Volume é: {_volume.Resultado}");
        }
    }
}