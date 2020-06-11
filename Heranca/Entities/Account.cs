using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }

        //construtor
        public Account()
        {
        }
        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        //Método para retirada de dinheiro
        public void Withdraw(double amount)
        {
            Balance -= amount;
        }
        //Método para deposito
        public void Deposit(double amount)
        {
            Balance += amount;
        }






    }
}
