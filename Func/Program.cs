using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;

namespace Func
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

            //Exemplo 1
            //Aqui vamos criar uma variavel do tipo func que será a referência para a nossa função
            //Func<Produto, String> func = NomeMaiusculo;

            //Agora vamos criar uma variavel de referÊncia func que receberá como parâmetro uma expressão lambda
            Func<Produto, string> func = p => p.Nome.ToUpper();
            
            //Exemplo 1
            //criamos uma nova lista, que recebera os resultados dos nomes, porém em maiúsculo, como argumento do select ela está
            //recebendo diretamente a função
            //List<string> resultado = listaProdutos.Select(NomeMaiusculo).ToList();
            
            //Exemplo 2
            //fazendo o select receber a variavel de referencia func
            //Também poderíamos colocar a nossa expressão lambda inline, passando diretamente como argumento para o nosso select
            //List<string> resultado = listaProdutos.Select(p => p.Nome.ToUpper()).ToList();
            List<string> resultado = listaProdutos.Select(func).ToList();
            foreach (string item in resultado)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();

        }

        //função para colocar os nomes dos produtos em letra maiúscula
        static string NomeMaiusculo(Produto obj)
        {
            return obj.Nome.ToUpper();
        }
    }
}
