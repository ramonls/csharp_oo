using Enums.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enums.Entidades.Enums;
namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            Pedido pedido = new Pedido { Id = 1080, Momento = DateTime.Now, Status = StatusDoPedido.PagamentoPendente };
            Console.WriteLine(pedido);

            //Conversão enumerado para string
            string txt = StatusDoPedido.PagamentoPendente.ToString();
            Console.WriteLine(txt);
            Console.WriteLine("");
            Console.Write("Digite o status do pedido: ");
            string status = Console.ReadLine();
            if(Enum.IsDefined(typeof(StatusDoPedido), status))
            {
                //Converter de String para Enumerado
                StatusDoPedido sp = (StatusDoPedido)Enum.Parse(typeof(StatusDoPedido), status);
                Console.WriteLine("Resultado = "+(int)sp);
            }
            else
            {
                Console.WriteLine("Status não encontrado!");
            }
            Console.ReadLine();

        }
    }
}
