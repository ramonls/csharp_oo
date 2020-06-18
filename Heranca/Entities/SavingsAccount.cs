using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca.Entities
{
    class SavingsAccount : Account
    {
        public double InteresRate { get; set; }

        //construtores
        public SavingsAccount()
        {
        }

        public SavingsAccount (int number, string holder, double balance, double interesRate) : base(number, holder, balance)
        {
            InteresRate = interesRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InteresRate;
        }

        //sobrescrita do método withdraw do superclasse
        public override void Withdraw(double amount)
        {
            //base.Withdraw(amount); ele realia a operação da superclasse
            Balance -= amount;
        }
        //No caso poderíamos deixar o base para ele realizar o método da superclasse e ainda, fazer outros procedimentos.
    }
}
