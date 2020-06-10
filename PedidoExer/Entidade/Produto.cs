﻿namespace PedidoExer.Entidade
{
    class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }

        //Construtor
        public Produto()
        {
        }

        public Produto (string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

    }
}
