using CBancariaExcecao.Entidade;
using CBancariaExcecao.Entidade.Excecao;
using System;
using System.Globalization;
using System.Threading.Channels;

namespace CBancariaExcecao
{
    class Program
    {
        static void Main(string[] args)
        {

            Conta conta = new Conta();
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
                conta = new Conta(numero, titular, saldoInicial, limiteRetirada);

                Console.WriteLine();
                Console.Write("Entre com o valor para retirada: R$");
                double valorRetirar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta.Retirada(valorRetirar);

            }
            catch (FormatException)
            {
                Console.WriteLine("Erro ao digitar informações");
            }
            catch (CBExcecao e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine(conta);
            Console.ReadLine();
        }
    }
}
