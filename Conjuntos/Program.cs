using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conjuntos
{
    class Program
    {
        static void Main(string[] args)
        {
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

            Console.ReadLine();
        }
    }
}
