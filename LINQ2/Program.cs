using System;
using System.Collections.Generic;
using System.Linq;
using LINQ2.Entities;

namespace LINQ2
{
    class Program
    {
        //Projeto LINQ com Lambda
        
        
        //função auxiliar para imprimir o objeto na tela, junto com a mensagem a ser passada
        static void Print<t>(string msg, IEnumerable<t> colecao)
        {
            Console.WriteLine(msg);
            foreach(t obj in colecao)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
        }

        
        static void Main(string[] args)
        {
            //Criando as categorias
            Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 2 };
            Category c2 = new Category() { Id = 2, Name = "Computers", Tier = 1 };
            Category c3 = new Category() { Id = 3, Name = "Electronics", Tier = 1 };

            //Criando os produtose instanciando os produtos dentro da lista
            //O nosso  product será o nosso data source (fonte de dados)
            List<Product> products = new List<Product>() { 
                new Product() {Id = 1, Name = "Computer", Price = 1100.0, Category = c2},
                new Product() {Id = 3, Name = "Hammer", Price = 90.0, Category = c1},
                new Product() {Id = 4, Name = "TV", Price = 1700.0, Category = c3},
                new Product() {Id = 5, Name = "Notebook", Price = 1300.0, Category = c2},
                new Product() {Id = 6, Name = "Saw", Price = 00.0, Category = c1},
                new Product() {Id = 7, Name = "Tablet", Price = 700.0, Category = c2},
                new Product() {Id = 8, Name = "Camera", Price = 700.0, Category = c3},
                new Product() {Id = 9, Name = "Printer", Price = 350.0, Category = c3},
                new Product() {Id = 10, Name = "MacBook", Price = 1800.0, Category = c2},
                new Product() {Id = 11, Name = "Sound Bar", Price = 700.0, Category = c3},
                new Product() {Id = 12, Name = "Level", Price = 70.0, Category = c1},
            };

            var resultado1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900.0);
            Print("Tier 1 e Preço < 900:", resultado1);


            var resultado2 = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name);
            Print("Nome dos produtos da categoria Tools:", resultado2);

            /*
             * Produtos começados com a letra C
             * Aqui estamos informando que o p.Name[0] ou seja a primeira letra do nome
             * Para mostrar o Nome o Preço e o nome da categoria, vamos utilizar um objeto anônimo (new {}), ou seja, é um objeto
             * que não está declarado em nenhuma das classes do nosso projeto ele é um objeto específico.
             * Para pegar no nome da categoria temos que dar um apelido para o atributo, pois já temos um Name que é o nome
             * do produto, fazemos como no SQL atribuindo apelido ao campo, no caso será o CategoryName
             */

            var resultado3 = products.Where(p => p.Name[0] == 'C').Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name});
            Print("Nomes começados com C e objeto anonimo:", resultado3);

            //Quando os preços forem iguais ele irá ordenar por nome
            var resultado4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);
            Print("Tier 1 ordenado por preço e também por nome:", resultado4);

            //Aqui vamos aproveitar o resultado4 e vamos utilizar o Skip() para pular e o Take para pegar
            //vamos pular 2 e pegar os próximos 4 resultados
            var resultado5 = resultado4.Skip(2).Take(4);
            Print("Tier 1 ordenado por preço e também por nome pulando os 2 primeiros e pegando 4:", resultado5);

            /*
             * O First() pega o primeiro elemento da nossa coleção, porém se não tiver ele retorna uma exceção
             * então ou fazemos um tratamento de exceção ou usamos o FirstOrDefaul() ele retorna nullo se não
             * tiver elemento em uma coleção
             * EX: var exemplo1 = products.FirstOrDefault()
             * ou casando com outra instrução
             * 
             * SingleOrDefault() retorna apenas um resultado, podemos fazer isso quando estamos fazendo uma busca por ID
             * se tirarmos o SingleOrDefaul o tipo de retorno será um IEnumerable ou seja, uma coleção
             * o SingleOrDefault não funciona se o nosso resultado retornar mais de um elemento ele da uma exceção.
             * Então, temos que usar quando temos certeza de que ele irá retornar ou 1 ou nenhum elemento.
            */
            var resultado6 = products.Where(p => p.Id == 3).SingleOrDefault();
            Console.WriteLine("Usando o SingleOrDefaul para um retorno de um unico elemento: "+resultado6);

            Console.ReadLine();
        }
    }
}
