using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Diagnostics.CodeAnalysis;

namespace Vetor
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Trabalhando com vetor
            Resolver o seguinte problema. [vetor que armazenará objeto do tipo classe]
            Fazer um programa para ler um número inteiro N e os dados (nome e preço) de N Produtos.
            Armazene os N produtos em um vetor. Em seguida, mostrar o preço médio dos produtos.
            */

            //ler quantidade de produtos
            int n = int.Parse(Console.ReadLine());

            //declarar o vetor do tipo produto que criamos
            Produto[] vetor = new Produto[n];

            for(int i=0; i<n; i++)
            {
                string nome = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                //como nosso vetor é do tipo objeto, temos que instanciar os objetos para ser criado dentro do vetor
                vetor[i] = new Produto { Nome = nome, Preco = preco};
            }

            double soma = 0.0;
            for(int i=0; i<n; i++)
            {
                soma += vetor[i].Preco;
            }

            double media = soma / n;
            Console.WriteLine();
            Console.WriteLine("Preço Médio R$"+media.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}
