using CBancariaExcecao.Entidade.Excecao;
using System.Globalization;

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
            if (limiteRetirada <= 0)
                throw new CBExcecao("Limite de retirada não pode ser menor ou igual a zero!");
            Numero = numero;
            Nome = nome;
            Saldo = saldo;
            LimiteRetirada = limiteRetirada;

        }

        public void Deposito(double montante)
        {

            if (montante <= 0)
                throw new CBExcecao("Valor não pode ser menor ou igual a zero!");
            Saldo += montante;

        }
        public void Retirada(double montante)
        {


            if (montante > LimiteRetirada)
                throw new CBExcecao("Erro - Valor superior ao limite de retirada!");
            if (montante > Saldo)
                throw new CBExcecao("Erro - Valor superior ao saldo!");
            Saldo -= montante;


        }

        public override string ToString()
        {
            return "Novo Saldo: R$" + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
