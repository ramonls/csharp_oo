using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ManipulandoDiretorio
{
    class Program
    {
        static void Main(string[] args)
        {
            string caminho = @"C:\csharp_aula";

            try
            {
                //Pastas
                IEnumerable<string> pastas = Directory.EnumerateDirectories(caminho, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Pastas:");
                foreach(string pasta in pastas)
                {
                    Console.WriteLine(pasta);
                }
                //Arquivos
                IEnumerable<string> arquivos = Directory.EnumerateFiles(caminho, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Arquivos:");
                foreach (string arquivo in arquivos)
                {
                    Console.WriteLine(arquivo);
                }

                Directory.CreateDirectory(caminho + @"\Nova Pasta");
            
            }
            catch (IOException e)
            {

                Console.WriteLine("Erro: " + e.Message);
            }
            Console.ReadLine();
        }
    }
}
