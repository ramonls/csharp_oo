using System;
using ContratoExerc.Entidades;

namespace ContratoExerc.Servicos
{
    class ServicoContrato
    {
        private IServicoPagamentoOnline _servicoPagamentoOnline;

        public ServicoContrato(IServicoPagamentoOnline servicoPagamentoOnline)
        {
            _servicoPagamentoOnline = servicoPagamentoOnline;
        }
        public void ProcessarContrato(Contrato contrato, int mes)
        {
            double CotaBasica = contrato.ValorTotal / mes;
            for(int i = 1; i <= mes; i++)
            {
                DateTime data = contrato.Data.AddMonths(i);
                double atualizacaoCota = CotaBasica + _servicoPagamentoOnline.Juros(CotaBasica, i);
                double cotaTotal = atualizacaoCota + _servicoPagamentoOnline.TaxaDePagamento(atualizacaoCota);
                contrato.AdicionarParcela(new Parcela(data, cotaTotal));
            }
        }

    }
}
