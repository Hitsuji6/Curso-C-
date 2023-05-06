using System;
using System.IO;

namespace Inicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string SourcePath = @"C:\Users\Micro\Desktop\teste.txt";
            string TargetPath = @"C:\Users\Micro\Desktop\teste2.txt";
            FileInfo fileinfo = new FileInfo(SourcePath);

            do
            {
                Console.WriteLine("----------------------");
                Console.WriteLine("1 - Olhar arquivo");
                Console.WriteLine("2 - Copiar arquivo");
                Console.WriteLine("3 - Escrever em um arquivo");
                Console.WriteLine("----------------------");
                Console.WriteLine("Entre com a opção: ");
                var opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        {
                            string[] linha = File.ReadAllLines(SourcePath);
                            foreach (string line in linha)
                            {
                                Console.WriteLine(line);
                            }
                            break;
                        }

                    case "2":
                        {
                            fileinfo.CopyTo(TargetPath);
                            break;
                        }

                    case "3":
                        {
                            using (StreamWriter sw = fileinfo.CreateText())
                            {
                                sw.WriteLine("Testado :D");
                            }
                                break;
                        }
                }

            } while (true);


        }
    }
}