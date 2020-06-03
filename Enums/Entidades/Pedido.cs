using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enums.Entidades.Enums;

namespace Enums.Entidades
{
    class Pedido
    {
        public int Id { get; set; }
        public DateTime Momento { get; set; }
        public StatusDoPedido Status { get; set; }

        public override string ToString()
        {
            return Id + ", " + Momento + ", " + Status;
        }
    }
}
