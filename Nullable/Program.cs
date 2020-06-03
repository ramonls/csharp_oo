using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            //definir um tipo de valor struct como nullable
            //Pode ser assim
            Nullable<double> a = null;
            //outro modo mais fácil
            double? x = null;
            double? y = 10.0;
            //GetValueOrDefault -> pegar o valor da variável ou o valor padrão se não tiver valor
            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            //HasValue -> essa propriedade vai verificar se dentro da variavel existe ou não o valor
            Console.WriteLine(x.HasValue); //False
            Console.WriteLine(y.HasValue); //True

            //Value -> pega o valor diretamente da variavel
            //Essa propriedade Value lança um exceção se o valor de uma variável nullable estiver nulo.
            if(x.HasValue)
                Console.WriteLine(x.Value);
            else
                Console.WriteLine("x é nulo!");

            if(y.HasValue)
                Console.WriteLine(y.Value);
            else
                Console.WriteLine("y é nulo!");

            //Operador de coalescÊncia ??
            double? b = null;
            double? c = 10;

            double d = b ?? 5; //se b for nulo recebe o valor 5
            double e = c ?? 5; //se c for nulo recebe o valor 5

            Console.WriteLine(d);
            Console.WriteLine(e);

            Console.ReadLine();
        }
    }
}
