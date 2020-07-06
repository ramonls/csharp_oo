using System;
using System.Globalization;

namespace ContratoExerc.Entidades
{
    class Parcela
    {
        DateTime DataVencimento { get; set; }
        double Valor { get; set; }

        public Parcela(DateTime dataVencimento, double valor)
        {
            DataVencimento = dataVencimento;
            Valor = valor;
        }

        public override string ToString()
        {
            return DataVencimento.ToString("dd/MM/yyyy")+" - "+ Valor.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
