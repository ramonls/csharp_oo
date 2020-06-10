using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using PedidoExer.Entidade.Enums;

namespace PedidoExer.Entidade
{
    class Pedido
    {
        public DateTime Momento { get; set; }
        public StatusPedido Status { get; set; }
        public Cliente Cliente { get; set; }
        public List<ItemPedido> Items { get; set; } = new List<ItemPedido>();

        //construtor
        public Pedido()
        {
        }

        public Pedido(StatusPedido status, Cliente cliente)
        {
            Momento = DateTime.Now;
            Status = status;
            Cliente = cliente;
        }

        public void AddItem(ItemPedido item)
        {
            Items.Add(item);
        }
        public void RemoverItem(ItemPedido item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double total = 0;
            foreach(ItemPedido item in Items)
            {
                total += (double)item.SubTotal();
            }
            return total;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Sumário do Pedido:");
            sb.Append("Momento do Pedido: ");
            sb.AppendLine(Momento.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.Append("Status do Pedido: ");
            sb.AppendLine(Status.ToString());
            sb.Append("Cliente: ");
            sb.Append(Cliente.Nome);
            sb.Append(" (");
            sb.Append(Cliente.DataNascimento.ToString("dd/MM/yyyy"));
            sb.Append(") - ");
            sb.AppendLine(Cliente.Email);
            sb.AppendLine("Itens do Pedido:");
            foreach(ItemPedido item in Items)
            {
                sb.Append(item.Produto.Nome);
                sb.Append(", $");
                sb.Append(item.Preco);
                sb.Append(", Quantidade: ");
                sb.Append(item.Quantidade);
                sb.Append(", Subtotal: $");
                sb.AppendLine(item.SubTotal().ToString());
            }
            sb.Append("Preço Total: $");
            sb.AppendLine(Total().ToString());

            return sb.ToString();
        }

        
    }
}
