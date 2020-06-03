using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            //Matriz  Linhas --> [2,3] <-- Colunas
            double[,] matriz = new double[2, 3];

            //Tamanho total da matriz
            Console.WriteLine("Tamanho total da matriz: " + matriz.Length);
            //Quantidade de linhas da matriz
            Console.WriteLine("Quantidade de linhas da matriz: "+matriz.Rank);
            //Ver o tamanho da dimensão 0 ou seja as linhas
            Console.WriteLine("Ver o tamanho da dimensão 0 ou seja as linhas: " + matriz.GetLength(0));
            //Ver o tamanho da dimensão na posição 1, no caso as colunas
            Console.WriteLine("Ver o tamanho da dimensão na posição 1, no caso as colunas: " + matriz.GetLength(1));


            Console.ReadLine();
        }
    }
}
