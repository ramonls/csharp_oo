using System;
using System.Globalization;
using CBancariaExcecao.Entidade;
using CBancariaExcecao.Entidade.Excecao;

namespace CBancariaExcecao
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enntre com as informações da conta:");
                Console.Write("Numero: ");
                int numero = int.Parse(Console.ReadLine());
                Console.Write("Titular: ");
                string titular = Console.ReadLine();
                Console.Write("Saldo Inicial: R$");
                double saldoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Limite de retirada: R$");
                double limiteRetirada = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            }
            

        }
    }
}
