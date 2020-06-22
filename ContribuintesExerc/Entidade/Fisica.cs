namespace ContribuintesExerc.Entidade
{
    class Fisica : Pessoa
    {
        public double GastoComSaude { get; set; }

        public Fisica(double gastoComSaude, string nome, double rendaAnual) : base(nome, rendaAnual)
        {
            GastoComSaude = gastoComSaude;
        }

        public override double Taxa()
        {
            double imposto;
            if (RendaAnual < 20000.00)
            {
                imposto = (RendaAnual * 0.15) - (GastoComSaude * 0.5);
            }
            else
            {
                imposto = (RendaAnual * 0.25) - (GastoComSaude * 0.5);
            }
            return imposto;
        }
    }
}
