using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca.Entities
{
    //A classe BusinessAccount extente a classe Account
    class BusinessAccount : Account
    {
        public double LoanLimit { get; set; }

        //construtores
        //Esse construtor fazio é apenas para criarmos o objeto vazio, sem a necessidade de passar os valores do objeto
        public BusinessAccount()
        {
        }

        /* Neste construtor, estamos reaproveitando o construtor da classe base(superclasse) para não precisar ter que colocar
         * todos os atributos novamente que o construtor precisa, para isso usamos : base() ao fazer isso podemos escolher qual
         * costrutor queremos usar da nossa classe base(superclasse).
         */
        public BusinessAccount(int number, string holder, double balance, double loanLimit) : base(number, holder, balance)
        {      
            LoanLimit = loanLimit;
        }

        //Implementar a classe de emprestimo
        public void Loan(double amount)
        {
            if(amount <= LoanLimit)
            {
                Balance += amount;
            }
        }
    }
}
