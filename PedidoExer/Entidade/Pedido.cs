using System;
using System.Collections.Generic;
using System.Linq;
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
            Cliente = Cliente;
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
                total += (double)item.Preco;
            }
            return total;
        }
    }
}
