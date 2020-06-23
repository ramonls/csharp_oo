using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net;
using System.Text;
using CBancariaExcecao.Entidade.Excecao;

namespace CBancariaExcecao.Entidade
{
    class Conta
    {
        public int Numero { get; set; }
        public string Nome { get; set; }
        public double Saldo { get; set; }
        public double LimiteRetirada { get; set; }

        public Conta()
        {
        }
        public Conta(int numero, string nome, double saldo, double limiteRetirada)
        {
            if (limiteRetirada < 0)
                throw new CBExcecao("Limite de retirada não pode ser menor que zero!");
            try
            {
                Numero = numero;
                Nome = nome;
                Saldo = saldo;
                LimiteRetirada = limiteRetirada;
            }
            catch(Exception e)
            {
                Console.WriteLine("Erro no construtor: "+e);
            }    
        }

        public void Deposito(double montante)
        {
            try
            {
                Saldo += montante;
            }
            catch(Exception e)
            {
                Console.WriteLine("Erro no deposito: "+e);
            }
        }
        public void Retirada(double montante)
        {
            try
            {
                if (montante > LimiteRetirada)
                    throw new CBExcecao("Erro - Valor superior ao limite de retirada!");
                if (montante > Saldo)
                    throw new CBExcecao("Erro - Valor superior ao saldo!");

                Saldo -= montante;
            }
            catch
            {
                Console.WriteLine("Erro na Retirada!");
            }
        }

        public override string ToString()
        {
            return "Novo Saldo: R$"+Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
