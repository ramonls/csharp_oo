using System;

namespace PedidoExer.Entidade
{
    class Cliente
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }

        //construtor
        public Cliente()
        {
        }

        public Cliente(string nome, string email, string dataNascimento)
        {
            Nome = nome;
            Email = email;
            DataNascimento = DateTime.Parse(dataNascimento);
        }
    }
}
