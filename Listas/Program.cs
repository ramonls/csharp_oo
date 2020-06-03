using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            --> Declarando uma lista
            List<string> lista = new List<string>();
            --> Declarando uma lista e adicionando valores na declaração
            List<string> lista2 = new List<string> {"Ramon", "Drielly"};
            --> Se fossemos adicionar um produto a lista, tereíamos que fazer da seguinte maneira
            lista.Add(new Produto (xx, xx));
            */

            List<string> lista = new List<string>();
            //Adicionando elementos
            lista.Add("Macaco");
            lista.Add("Girafa");
            lista.Add("Elefante");
            lista.Add("Crocodilo");
            lista.Add("Esquilo");
            lista.Add("Abelha");
            lista.Add("Gafanhoto");
            lista.Add("Cavalo");
            lista.Add("Bufalo");
            lista.Add("Rinoceronte");

            //Adicionando um elemento na posição 2
            lista.Insert(2, "Aguia");
            Console.WriteLine("*******************************************************");
            foreach(string obj in lista)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("*******************************************************");
            //Tamanho da lista Count
            Console.WriteLine("Tamanho da lista: "+lista.Count);
            Console.WriteLine("*******************************************************");
            //Encontrar a primeira ocorrencia que começa com a letra E usando lambda
            string nome1 = lista.Find(X => X[0] == 'E');
            Console.WriteLine("Primeiro nome que começa com a letra E: "+nome1);
            Console.WriteLine("*******************************************************");
            //Encontrar a última ocorrencia que começe com a letra E usando lambda
            string nome2 = lista.FindLast(x => x[0] == 'E');
            Console.WriteLine("Ultimo nome que começa com a letra E: "+nome2);
            Console.WriteLine("*******************************************************");
            //Encontrar a primeira posição que começa com a letra E
            int posicao1 = lista.FindIndex(x => x[0] == 'E');
            Console.WriteLine("Primeira posição que começa com a letra E: "+posicao1);
            Console.WriteLine("*******************************************************");
            //Encontrar a última posição que começa com a letra E
            int posicao2 = lista.FindLastIndex(x => x[0] == 'E');
            Console.WriteLine("Última posição que começa com a letra E: "+posicao2);
            Console.WriteLine("*******************************************************");
            //Vamos filtrar os elementos e separar todos os elementos que tenham o tamanho de 6 caractere usando o FindAll
            List<string> listaSeis = lista.FindAll(x => x.Length == 6);
            Console.WriteLine("Lista com nomes que contenham seis caractere:");
            foreach(string obj in listaSeis)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("*******************************************************");
            //Removendo o elemento Gafanhoto
            lista.Remove("Gafanhoto");
            Console.WriteLine("Gafanhoto removido da lista.");
            //Removendo todos os animais que começam com a letra E
            lista.RemoveAll(x => x[0] == 'E');
            Console.WriteLine("Todos os animais que começam com a letra E foram removidos.");
            //Removendo o animal na posição 3
            lista.RemoveAt(3);
            Console.WriteLine("Animal na posição 3 foi removido.");
            //removendo 3 animais a partir da posição 1
            lista.RemoveRange(1, 3);
            Console.WriteLine("Removido 3 animais a partir da posição 1.");
            Console.WriteLine("*******************************************************");
            Console.WriteLine("Elementos que sobraram na lista:");
            foreach(string obj in lista)
            {
                Console.WriteLine(obj);
            }
            Console.ReadLine();


        }
    }
}
