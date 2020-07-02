using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;

namespace ArqCSVExerc
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string ArquivoCSV = @"C:\csharp_aula\vendas.csv";

            try
            {
                using (FileStream arquivo = new FileStream(ArquivoCSV, FileMode.Open))
                {
                    using (StreamReader leituraArquivo = new StreamReader(arquivo))
                    {
                        while (!leituraArquivo.EndOfStream)
                        {
                            string linha = leituraArquivo.ReadLine();
                            string[] elemento = linha.Split(',');
                            double preco = double.Parse(elemento[1], CultureInfo.InvariantCulture);
                            int quantidade = int.Parse(elemento[2]);
                            double total = quantidade * preco;
                            Console.WriteLine(elemento[0]+", "+total.ToString("F2", CultureInfo.InvariantCulture));
                        }
                    }
                }
            }
            catch (IOException e)
            {

                Console.WriteLine("Erro: "+e.Message);
            }

            Console.ReadLine();
        }
    }
}
