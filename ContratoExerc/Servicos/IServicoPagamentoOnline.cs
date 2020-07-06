namespace ContratoExerc.Servicos
{
    interface IServicoPagamentoOnline
    {
        double TaxaDePagamento(double valor);
        double Juros(double valor, int mes);
    }
}
