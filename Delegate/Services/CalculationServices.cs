using System;
using System.Collections.Generic;
using System.Text;

namespace Delegate.Services
{
    class CalculationServices
    {
        /* Exemplo 1
        //Uma classe com métodos para calcular (Número máximo, soma e quadrado)
        public static double Max(double x, double y)
        {
            return (x > y) ? x : y;
        }

        public static double Sum(double x, double y)
        {
            return x + y;
        }

        public static double Square(double x)
        {
            return x * x;
        }*/

        //Exemplo 2 - agora eles não retornam e já apresenta o valor na tela.

        public static void ShowMax(double x, double y)
        {
            double max = (x > y) ? x : y;
            Console.WriteLine(max);
        }
        public static void ShowSum(double x, double y)
        {
            double sum = x + y;
            Console.WriteLine(sum);
        }

    }
}
