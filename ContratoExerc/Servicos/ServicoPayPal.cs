namespace ContratoExerc.Servicos
{
    class ServicoPayPal : IServicoPagamentoOnline
    {
        private const double PorcentagemTaxa = 0.02;
        private const double JurosMes = 0.01;

        public double TaxaDePagamento(double valor)
        {

            return valor * PorcentagemTaxa;
        }

        public double Juros(double valor, int mes)
        {
            return valor * JurosMes * mes;
        }
    }
}
