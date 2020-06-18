using Heranca.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001, "Alex", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);

            //Upcasting
            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
            Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);

            //DownCasting
            BusinessAccount acc4 = (BusinessAccount)acc3;
            acc4.Loan(100.0);

            //Outra forma de converter (casting) usando a palavra reservada as
            BusinessAccount acc6 = acc3 as BusinessAccount;

            /*
            * BusinessAccount acc5 = (BusinessAccount) acc3;
            * a variável acc3 é do tipo SavingsAccount, visto as duas ser subclasse, o sistema irá apresentar
            * o erro na execução do sistema, para que possamos testar se uma variável é de um tipo usamos
            * a palavra reservada is
            */
            //Se a variável acc3 for do tipo BusinessAccount --> Irá atribuir e converter <--
            if(acc3 is BusinessAccount)
            {
                BusinessAccount acc5 = (BusinessAccount)acc3;
            }

        }
    }
}
