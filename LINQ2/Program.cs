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
                new Product() {Id = 6, Name = "Saw", Price = 80.0, Category = c1},
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

            //vamos utilizar o Max para buscar o maio preço dos produtos
            //se não usarmos a expressão lambda ele espera que o seu objeto tenho um método de comparação IComparable
            //se não ele retorna uma exceção
            //Podemos usar o Min() para um resultado oposto, mínimo.
            var resultado7 = products.Max(p => p.Price);
            Console.WriteLine("O maior preço: "+ resultado7);

            //vamos obter a soma dos produtos da categoria 1
            var resultado8 = products.Where(p => p.Category.Id == 1).Sum(p => p.Price);
            Console.WriteLine("Soma dos produtos da categoria 1: "+ resultado8);

            //Podemos fazer a média com o Average(), seguindo os mesmos passos do Sum
            //se der uma colação vazia ele vai apresentar uma exceção.
            //vamos fazer um exemplo de uma categoria que não existe, porém vamos utilizar o DefaultIfEmpty()
            //que no caso iremos verificar se ele for nulo, podemos colocar como argumento um valor a ser apresentado
            //Estamos pesquisando os produtos da categoria 5, convertendo para double com o select, defindo um valor caso
            //a coleção retorne vazia (0.0) e depois estamos pedindo para fazer a média, caso a coleção não esteja vazia
            var resultado9 = products.Where(p => p.Category.Id == 5).Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine("Médias dos valores da Categoria 5: "+resultado9);

            //Em outras linguagens tem o nome de Map / Redux
            //Aqui em C# tem o nome de Select / Aggregate
            //Vamos fazer uma soma manual dos produtos da categoria 1
            //no aggregate vamos fazer uma função anonima, e antes vamos colocar um valor padrão
            //para se caso ele não achar nenhuma elemento na coleção para fazer a soma, ele irá utilizar o
            //valor padrão que na soma será 0 e 0.0 para double
            var resultado10 = products.Where(p => p.Category.Id == 1).Select(p => p.Price).Aggregate(0.0, (x, y) => x + y);
            Console.WriteLine("Soma (manual) dos valor da categoria 1 "+ resultado10);
            Console.WriteLine();
            //Operação de agrupamento
            //cada elemento retorna do tipo IGrouping<Category, Product>
            var resultado11 = products.GroupBy(p => p.Category);
            //O tipo para o foreach terá que ser do mesmo tipo para ele percorre e gravar na variavel
            //terá uma chave Category e uma coleção Product
            foreach(IGrouping<Category, Product> group in resultado11)
            {
                Console.WriteLine("Categoria "+group.Key.Name+":");
                //vamos fazer outro foreach para imprimir os produtos dessa categoria
                foreach(Product p in group)
                {
                    Console.WriteLine(p);
                }
                Console.WriteLine();

            }

            Console.ReadLine();
        }
    }
}
