using System;
using System.Collections.Generic;
using System.IO;

namespace DictionaryExerc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();
            Dictionary<string, int> eleicao = new Dictionary<string, int>();

            using (StreamReader sr = new StreamReader(File.OpenRead(path)))
            {
                while (!sr.EndOfStream)
                {

                    string[] line = sr.ReadLine().Split(',');
                    string candidato = line[0];
                    int votos = int.Parse(line[1]);

                    if (eleicao.ContainsKey(candidato))
                    {
                        eleicao[candidato] += votos;
                    }
                    else
                    {
                        eleicao[candidato] = votos;
                    }
                }
                foreach(var item in eleicao)
                {
                    Console.WriteLine(item.Key+": "+item.Value);
                }
            }
            Console.ReadLine();
        }
    }
}
