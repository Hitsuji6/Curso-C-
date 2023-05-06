using System;
using System.IO;

namespace Arquivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\Micro\Desktop\PC.txt";
            string targetPath = @"C:\Users\Micro\Desktop\PC2.txt";
            string Path = @"C:\Users\Micro\Desktop\sites.txt";

            FileInfo fileInfo = new FileInfo(sourcePath);
            FileInfo fi = new FileInfo(Path);

            using (StreamWriter sw = fi.CreateText())
            {
                sw.WriteLine("GINEAD - Cursos");
                sw.WriteLine("freeCodeCamp - Cursos");
                
            }

            fileInfo.CopyTo(targetPath);
            string[] lines = File.ReadAllLines(sourcePath);
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
            
        }
    }
}