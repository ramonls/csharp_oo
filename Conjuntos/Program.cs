using System;
using System.Collections.Generic;

namespace Conjuntos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciar uma coleção inserindo elementos, isso pode ser feitos para outras coleções
            SortedSet<int> conjunto = new SortedSet<int>() {1, 5, 9, 7, 58, 12, 49, 35 };

            //Poderiamos também definir um conjunto e atribuindo os elementos de outro conjunto
            //No caso abaixo, a coleção conjunto receberia os valores do conjunto A
            //SortedSet<int> conjunto = new SortedSet<int>(A);

            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();
            HashSet<int> C = new HashSet<int>();
            HashSet<int> total = new HashSet<int>();

            Console.Write("O curso A possui quantos alunos? ");
            int QntAlunos = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os códigos dos alunos do curso A:");
            for(int i=0; i<QntAlunos; i++)
            {
                A.Add(int.Parse(Console.ReadLine()));

            }
            Console.Write("O curso B possui quantos alunos? ");
            QntAlunos = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os códigos dos alunos do curso B:");
            for(int i=0; i<QntAlunos; i++)
            {
                B.Add(int.Parse(Console.ReadLine()));
            }
            Console.Write("O curso C possui quantos alunos? ");
            QntAlunos = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os códigos dos alunos do curso C:");
            for (int i = 0; i < QntAlunos; i++)
            {
                C.Add(int.Parse(Console.ReadLine()));
            }
            total.UnionWith(A);
            total.UnionWith(B);
            total.UnionWith(C);
            int contador = 0;
            foreach(int e in total)
            {
                contador++;
            }
            Console.WriteLine("Total de alunos: "+contador);
            Console.WriteLine();
            Console.WriteLine("Valores que foram inseridos no momento da instanciação do SortedSet:");
            PrintCollection(conjunto);

            Console.ReadLine();
        }
        //fazer uma função para imprimir os objetos na tela, de forma genérica para qualquer coleção possa utiliza-lá
        static void PrintCollection<T>(IEnumerable<T> collection)
        {
            foreach(T obj in collection)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
        }
    }
}
