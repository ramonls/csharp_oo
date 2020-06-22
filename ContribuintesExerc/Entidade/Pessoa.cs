using System;
using System.Collections.Generic;
using System.Text;

namespace ContribuintesExerc.Entidade
{
    abstract class Pessoa
    {
        public String Nome { get; set; }
        public double RendaAnual { get; set; }

        public Pessoa (string nome, double rendaAnual)
        {
            Nome = nome;
            RendaAnual = rendaAnual;
        }

        public abstract double Taxa();
    }
}
