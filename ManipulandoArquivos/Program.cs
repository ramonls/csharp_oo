using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;

namespace ManipulandoArquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sem o @ teriamos que colocar duas barras. EX: "C:\\csharp_aula\\arquivo1.txt"
            string caminhoOrigem = @"C:\csharp_aula\arquivo1.txt";
            //string caminhoDestino = @"C:\csharp_aula\arquivo2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(caminhoOrigem);
                //faz uma cópia do arquivo
                //fileInfo.CopyTo(caminhoDestino);
                //Criamos um vetor linhas, ele vai receber todas as linhas que estão no arquivo caminhOrigem
                string[] linhas = File.ReadAllLines(caminhoOrigem);
                foreach(string linha in linhas)
                {
                    Console.WriteLine(linha);
                }

            }
            catch (IOException e)
            {

                Console.WriteLine("<o> Erro-> "+e.Message);
            }

            //Usando FileStream e StreamReader
            Console.WriteLine();
            Console.WriteLine("#########################################");

            //FileStream fs = null;
            StreamReader sr = null;
            try
            {
                //fs = new FileStream(caminhoOrigem, FileMode.Open);
                //sr = new StreamReader(fs);
                sr = File.OpenText(caminhoOrigem);
                while (!sr.EndOfStream)
                {
                    string linha = sr.ReadLine();
                    Console.WriteLine("Linha do arquivo -> " + linha);
                }
               
            }
            catch (IOException e)
            {

                Console.WriteLine("<o> Erro -> "+e.Message);
            }
            finally
            {
                //Fechando manualmente sr e fs
                //se o sr e o fs estiver aberto
                if (sr != null) sr.Close();
                //if (fs != null) fs.Close();
                
            }

            Console.WriteLine();
            /*
             * Aqui vamos usar o bloco using, para quando o procedimento de manipular o arquivo terminar ele
             * fechar automaticamente, sem ser preciso fechar manualmente.
             */
            Console.WriteLine("### Usando o bloco using ###");
            Console.WriteLine();

            try
            {
                using(FileStream FS = new FileStream(caminhoOrigem, FileMode.Open))
                {
                    using(StreamReader SR = new StreamReader(FS))
                    {
                        while (!SR.EndOfStream)
                        {
                            string line = SR.ReadLine();
                            Console.WriteLine("Linha(using): "+line);
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
