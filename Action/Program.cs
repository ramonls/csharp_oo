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
            //passando por e
            //listaProdutos.ForEach(AtualizacaoPreco);

            //Usando expressão lambda, entre {...} que representa que não terá nenhum retorno (void)
            listaProdutos.ForEach(p => { p.Preco += p.Preco * 0.1; });

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
