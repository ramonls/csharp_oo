using System;
using System.Collections.Generic;
using System.Text;

namespace ContaBancaria
{
    class ContaBancaria
    {
        private string _titular;
        private double _saldo;
        public int NumeroConta { get; private set; }

        public ContaBancaria (int numeroConta, string titular)
        {
            NumeroConta = numeroConta;
            Titular = titular;
        }
        public ContaBancaria (int numeroConta, string titular, double saldo) :this (numeroConta, titular)
        {
            Saldo = saldo;
        }

        public string Titular
        {
            get { return _titular; }
            set {
                if (value != null && value.Length > 1)
                    _titular = value;
            }
        }
        public double Saldo
        {
            get { return _saldo; }
            set {
                if (value > 0)
                    _saldo += value;
            }
        }

        public void Deposito (double quantia)
        {
            Saldo = quantia;
        }
        public void Saque (double quantia)
        {
            _saldo -= quantia + 5.00;
        }

        public override string ToString()
        {
            return "Conta: "+NumeroConta+", Titular: "+Titular +", Saldo: "+Saldo;
        }

    }
}
