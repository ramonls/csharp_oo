using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace AluguelQuarto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos quartos irá alugar? ");
            int nQuartos = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Cliente[] vetor = new Cliente[10];

            for(int i=0; i < nQuartos; i++)
            {
                Console.WriteLine("Aluguel #"+(i+1)+":");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                vetor[quarto] = new Cliente { Nome = nome, Email = email, Quarto = quarto };
                Console.WriteLine("");
            }
            Console.WriteLine("Quartos Ocupados:");
            for(int i=0; i < 10; i++)
            {
                if(vetor[i] != null)
                {
                    Console.WriteLine(vetor[i].Quarto+": "+vetor[i].Nome+", "+vetor[i].Email);
                }
            }
            Console.ReadLine();
        }
    }
}
