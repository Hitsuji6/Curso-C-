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
            FileInfo targetinfo = new FileInfo(TargetPath);

            do
            {
                
                Console.WriteLine("----------------------");
                Console.WriteLine("1 - Escrever no arquivo");
                Console.WriteLine("2 - Copiar arquivo");
                Console.WriteLine("3 - Olhar arquivo");
                Console.WriteLine("4 - Excluir arquivo(s)");
                Console.WriteLine("----------------------");
                Console.WriteLine("Entre com a opção: ");
                var opcao = Console.ReadLine();
                Console.WriteLine("");

                switch (opcao)
                {
                    case "1":
                        {
                            using (StreamWriter sw = fileinfo.CreateText())
                            {
                                Console.WriteLine("Escreva aqui: ");
                                string resposta = Console.ReadLine();
                                Console.WriteLine("");
                                sw.WriteLine(resposta);
                            }
                            break;
                        }

                    case "2":
                        {
                            fileinfo.CopyTo(TargetPath);
                            Console.WriteLine("Arquivo copiado com sucesso!! :D");
                            Console.WriteLine("");
                            break;
                        }

                    case "3":
                        {
                            try
                            {
                                string[] linha = File.ReadAllLines(SourcePath);
                                foreach (string line in linha)
                                {
                                    Console.WriteLine(line);
                                    Console.WriteLine("");
                                }
                            }
                            catch (IOException e)
                            {
                                Console.WriteLine("Erro ao encontrar arquivo!!");
                                Console.WriteLine(e.Message);
                                Console.WriteLine("");
                            }
                                break;
                        }

                    case "4":
                        {
                            Console.WriteLine("Deletar o arquivo junto com a cópia?");
                            Console.WriteLine("1 - SIM");
                            Console.WriteLine("2 - NÃO");
                            int resposta = int.Parse(Console.ReadLine());
                            Console.WriteLine("");

                            if (resposta == 1)
                            {
                                fileinfo.Delete();
                                targetinfo.Delete();
                                Console.WriteLine("Arquivos deletados com sucesso!!");
                                Console.WriteLine("");
                            }
                            else if(resposta == 2)
                            {
                                fileinfo.Delete();
                                Console.WriteLine("Arquivo deletado com sucesso!!");
                            }
                            break;
                        }
                    
                }

            } while (true);


        }
    }
}