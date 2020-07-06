using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using ContratoExerc.Entidades;
using ContratoExerc.Servicos;
using System.Data.SqlTypes;

namespace ContratoExerc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com as informações do contrato:");
            Console.Write("Numero: ");
            int numeroContrato = int.Parse(Console.ReadLine());
            Console.Write("Data (dd/mm/aaaa): ");
            DateTime dataContrato = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Valor do contrato: R$");
            double valorContrato = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Entre com o numero de parcelas: ");
            int numeroParcelas = int.Parse(Console.ReadLine());

            Contrato meuContrato = new Contrato(numeroContrato, dataContrato, valorContrato);
            ServicoContrato servicoContrato = new ServicoContrato(new ServicoPayPal());
            servicoContrato.ProcessarContrato(meuContrato, numeroParcelas);

            Console.WriteLine("Parcelas: ");
            foreach(Parcela parcelas in meuContrato.Parcela)
            {
                Console.WriteLine(parcelas);
            }

            Console.ReadLine();
        }
    }
}
