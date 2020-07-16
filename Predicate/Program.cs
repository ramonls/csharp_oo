using System;
using System.Collections.Generic;

namespace Predicate
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

            //neste caso estamos usando uma expressão lambda
            //remover todos o objeto p tal que p.preco seja menor que 700.00
            //listaProdutos.RemoveAll(p => p.Preco < 700.0);

            //Porém, poderíamos criar uma função substituiria a expressão lambda
            listaProdutos.RemoveAll(ComparaPreco);
            //No RemoveAll, qualquer função que respeita a assinatura do predicate, irá funcionar

            foreach(Produto item in listaProdutos)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
        //função que substituiria a expressão lambda, em ocasiões que dê para usar a expressão lambda é melhor.
        public static bool ComparaPreco(Produto obj)
        {
            return obj.Preco < 700.00;
        }
    }
}
