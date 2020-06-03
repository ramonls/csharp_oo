using System;
using System.Globalization;

namespace ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre o número da conta: ");
            int conta = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (S/N)? ");
            string sn = Console.ReadLine();
            ContaBancaria cliente;
            if(sn == "s" || sn == "S")
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                cliente = new ContaBancaria(conta, titular, depositoInicial);
            }
            else
            {
                cliente = new ContaBancaria(conta, titular);
            }
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(cliente);
            Console.WriteLine("");
            Console.Write("Entre um valor para depósito: ");
            cliente.Deposito(double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture));
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(cliente);
            Console.WriteLine("");
            Console.Write("Entre um valor para saque: ");
            cliente.Saque(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(cliente);

        }
    }
}
