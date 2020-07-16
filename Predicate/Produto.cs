using System;
using System.Collections.Generic;
using System.Text;

namespace Predicate
{
    class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public override string ToString()
        {
            return Nome + " - R$" + Preco.ToString("F2");
        }
    }
}
