using Delegate.Services;
using System;

namespace Delegate
{
    /* Exemplo 1 - este exemplo retorna um valor do tipo double
     * Aqui declaramos um delegate, esse delegate está informando que ele vai ser uma referência a uma
     * função, que receberá dois números double. e retorna um número double.
     * 
    delegate double OperacaoNumeroBinario(double n1, double n2);
    */

    //Exemplo 2 - referenciando mais funções ao delegate, e sem retorno (void) [MultiCast]
    delegate void OperacaoNumeroBinario(double x, double y);

    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;
            /* Exemplo 1
            //Vamos declarar um objeto do tipo OperacaoNumeroBinario, recebendo um dos  método da nossa classe CalculationServices
            //O objeto operacao é uma referência para a função Sum que está em CalculationServices.
            OperacaoNumeroBinario operacao = CalculationServices.Sum;
            //>>> Outra sintaxe alternativa
            //OperacaoNumeroBinario operacao = new OperacaoNumeroBinario(CalculationServices.Sum);
            //Porém fica mais verboso.


            //Criamos uma variavel que receberá o nosso objeto delegate que está referenciando a função sum.
            double resultado = operacao(a, b);
            //>>> Sintaxe alternativa
            //Se desejar poderemos utilizar a palavra reservada Invoke, para invocar a função, porém é o mesmo resultado acima.
            //double resultado = operacao.Invoke(a, b);
            Console.WriteLine(resultado);
            */

            //Objeto do tipo delegate recebendo a referencia do método da classe
            OperacaoNumeroBinario operacao = CalculationServices.ShowSum;
            //Aqui vamos fazer um multicast para que ele receba a referência do outro método também, executando as duas funções
            operacao += CalculationServices.ShowMax;

            //Como ele é void, não tem retorno vamos chamar ele da seguinte maneira:
            operacao.Invoke(a, b);


            Console.ReadLine();
        }
    }
}
