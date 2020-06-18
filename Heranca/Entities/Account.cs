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
        //virtual é para indicar que ele pode ser sobrescrito nas subclasses
        public virtual void Withdraw(double amount)
        {
            Balance -= amount + 5.0; //5.0 é a taxa que é descontada quando faz um saque
        }
        //Método para deposito
        public void Deposit(double amount)
        {
            Balance += amount;
        }






    }
}
