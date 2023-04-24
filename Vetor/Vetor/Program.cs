using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
namespace Vetor {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Quantos valores serão atribuidos? ");
            int n = int.Parse(Console.ReadLine());

            double[] vet = new double[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Entre com o valor da altura: ");
                vet[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double soma = 0;

            for (int i = 0; i < n; i++)
            {
                soma += vet[i];
            }

            double media = soma / n;
            Console.WriteLine($"A média entre as alturas é: {media.ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}