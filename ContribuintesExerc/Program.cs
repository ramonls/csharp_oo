using System;
using System.Runtime.Serialization.Formatters;
using System.Globalization;
using System.Collections.Generic;
using ContribuintesExerc.Entidade;

namespace ContribuintesExerc
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> lista = new List<Pessoa>();
            Console.Write("Entre com o numero de pagamentos de taxa: ");
            int numeroTaxa = int.Parse(Console.ReadLine());

            for(int i=1; i<= numeroTaxa; i++)
            {
                Console.WriteLine($"Informações do pagamento da taxa #{i}:");
                Console.Write("Física ou Juridica (f/j): ");
                char tipo = char.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Renda Anual: R$");
                double rendaAnual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(tipo == 'f')
                {
                    Console.Write("Despesa Médica: R$");
                    double despesaMedica = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    lista.Add(new Fisica(despesaMedica, nome, rendaAnual));
                }
                if(tipo == 'j')
                {
                    Console.Write("Numero de Empregados: ");
                    int numeroEmpregado = int.Parse(Console.ReadLine());
                    lista.Add(new Juridica(numeroEmpregado, nome, rendaAnual));
                }
            }
            Console.WriteLine();
            Console.WriteLine("Pagamentos de Taxa:");
            double somaTaxa = 0;
            foreach (Pessoa pessoa in lista)
            {
                Console.WriteLine(pessoa.Nome + " : R$" + pessoa.Taxa().ToString("F2", CultureInfo.InvariantCulture));
                somaTaxa += pessoa.Taxa();
            }
            Console.WriteLine();
            Console.WriteLine("Total Taxas: R$" + somaTaxa.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
