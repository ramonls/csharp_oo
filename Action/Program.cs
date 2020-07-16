using System;
using System.Collections.Generic;

namespace Action
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> listaProdutos = new List<Produto>();
            listaProdutos.Add(new Produto("TV 4K", 2565.36));
            listaProdutos.Add(new Produto("Radio", 652.65));
            listaProdutos.Add(new Produto("Mouse", 65.99));
            listaProdutos.Add(new Produto("Tablet", 899.99));

            //vamos usar o ForEach da propriedade list que pede um action, ou seja uma função que recebe um produto e que seja void, não tenha retorno
            //criamos uma função que não retonar nada, apenas faz o proceidmento, ele satifaz o parâmetro do tipo Action, sendo referencia de um método, porém não retornando valor.
            //listaProdutos.ForEach(AtualizacaoPreco);

            //Outra forma de fazer é criar uma variavel do tipo Action<>, recebedo a nossa função AtualizacaoPreco
            //Neste caso a variavel passará a ser referência para a nossa função, precisando passar apenas ela como argumento
            //Poderíamos fazer a variável atc receber a expressão lambda também.
            Action<Produto> atc = AtualizacaoPreco;


            //Usando expressão lambda, entre {...} que representa que não terá nenhum retorno (void)
            listaProdutos.ForEach(p => { p.Preco += p.Preco * 0.1; });
            //Passando como parâmetro a nossa variavel do tipo Action que é referência para a nossa função AtualizacaoPreco
            //listaProdutos.ForEach(atc); mais uma forma que poderá ser utilizada, no lugar das outras acima.

            foreach(Produto item in listaProdutos)
            {
                Console.WriteLine(item);
            }


            Console.ReadLine();


        }
        //essa função serve como parâmetro a ser passado quando é solicitado um Action
        static void AtualizacaoPreco(Produto obj)
        {
            obj.Preco += obj.Preco * 0.1;
        }
    }
}
