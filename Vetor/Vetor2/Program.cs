using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace Vetor2 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Entre com a quantidade de Produtos: ");
            int n = int.Parse(Console.ReadLine());

            Produtos[] vet = new Produtos[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Entre com o nome do produto: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Entre com o valor do produto: ");
                double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vet[i] = new Produtos { Nome = nome, Valor = valor };
            }

            double soma = 0;

            for (int i = 0; i < n; i++)
            {
                soma += vet[i].Valor;
            }

            double media = soma / n;

            Console.WriteLine($"O valor médio dos produtos é: {media.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}