using System;

namespace TipoValorStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            //Como todo tipo valor, é preciso inicializar a variável, pois se tentarmos
            //imprimir na tela uma variavel do tipo struct não inicializada o programa não irá permitir
            Point p;
            p.X = 10;
            p.Y = 20;
            Console.WriteLine(p);

            //O sistema também permite que chamamos ela pelo new
            p = new Point();
            //Ao iniciarmos ela com o new, e não atribuimos valor, ele inicializa com o valor 0 nas variaveis
            Console.WriteLine(p);
        }
    }
}
