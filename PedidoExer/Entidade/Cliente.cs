using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedidoExer.Entidade
{
    class Cliente
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        DateTime DataNascimento { get; set; }

        //construtor
        public Cliente()
        {
        }

        public Cliente(string nome, string email, DateTime dataNascimento)
        {
            Nome = nome;
            Email = email;
            DataNascimento = dataNascimento;
        }
    }
}
