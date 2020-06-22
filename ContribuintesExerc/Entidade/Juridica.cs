namespace ContribuintesExerc.Entidade
{
    class Juridica : Pessoa
    {
        public int NumeroFuncionario { get; set; }

        public Juridica(int numeroFuncionario, string nome, double rendaAnual) : base(nome, rendaAnual)
        {
            NumeroFuncionario = numeroFuncionario;
        }

        public override double Taxa()
        {
            double imposto;
            if (NumeroFuncionario > 10)
            {
                imposto = (RendaAnual * 0.14);
            }
            else
            {
                imposto = (RendaAnual * 0.16);
            }

            return imposto;
        }
    }
}
