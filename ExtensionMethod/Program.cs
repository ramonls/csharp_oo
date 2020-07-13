using ExtensionMethod.Extensions;
using System;

namespace ExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criar uma extensão de método
            DateTime dt = new DateTime(2020, 6, 12, 16, 30, 15);
            Console.WriteLine(dt.ElapsedTime());
            
            Console.WriteLine();
            string s1 = "De gole em gole, eu ajudo a salvar o planeta!";
            Console.WriteLine(s1.Cut(10));


            Console.ReadLine();
        }
    }
}
