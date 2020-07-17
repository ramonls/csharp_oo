using System;
using System.Linq; //importando o LINQ

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //Passos para se trabalhar com LINQ
            //1º passo -> especificar a fonte de dados (BD, array, list etc)
            int[] numeros = new int[] { 2, 3, 4, 5 };

            //2º passo -> definir a expressão de consulta
            var resultado = numeros.Where(x => x % 2 == 0).Select(x => x * 10);

            //3º passo ->  Executar a consulta
            foreach(int x in resultado)
            {
                Console.WriteLine(x);
            }

            //O LINQ trabalha com IEnumerable, é uma classe mais genêrica, mais flexível, se reparar no tipo
            //do var resultado, será IEnumerable, se fossemos gravar em uma lista, no final teríamos que converter
            //para lista .ToList()

            Console.ReadLine();
        }
    }
}
