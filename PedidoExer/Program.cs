using PedidoExer.Entidade;
using PedidoExer.Entidade.Enums;
using System;
using System.Globalization;

namespace PedidoExer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com as informações do cliente:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Data de Nascimento (DD/MM/AAAA): ");
            String dataNascimento = Console.ReadLine();
            Console.WriteLine("Entre com os dados do pedido:");
            Cliente cliente = new Cliente(nome, email, dataNascimento);
            Console.Write("Status: ");
            StatusPedido status = (StatusPedido) StatusPedido.Parse(typeof(StatusPedido), Console.ReadLine());
            Pedido pedido = new Pedido(status, cliente);
            ItemPedido itemPedido;

            Console.Write("Quantos itens tem o pedido? ");
            int quantidadeItem = int.Parse(Console.ReadLine());
            for(int i=1; i <= quantidadeItem; i++)
            {
                Console.WriteLine($"Entre com dados do item #{i}");
                Console.Write("Nome do Produto: ");
                string nomeProduto = Console.ReadLine();
                Console.Write("Preço: ");
                double precoProduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantidade: ");
                int quantidadeProduto = int.Parse(Console.ReadLine());
                Produto produto = new Produto(nomeProduto, precoProduto);
                itemPedido = new ItemPedido(quantidadeProduto, precoProduto, produto);
                pedido.AddItem(itemPedido);
            }
            Console.WriteLine("");
            Console.WriteLine(pedido);           
            Console.ReadLine();
        }
    }
}
