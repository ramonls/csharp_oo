using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            //PrintService<string> printService = new PrintService<string>(); PrintService do tipo string
            PrintService<int> printService = new PrintService<int>(); //PrintService do tipo int
            Console.Write("How many values? ");
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                printService.AddValue(x);
            }

            printService.Print();
            Console.WriteLine("First: "+printService.First());
            Console.ReadLine();
        }
    }
}
