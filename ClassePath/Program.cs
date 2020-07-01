using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassePath
{
    class Program
    {
        static void Main(string[] args)
        {
            string caminho = @"C:\csharp_aula\arquivo1.txt";

            Console.WriteLine("GetDirectoryName: "+Path.GetDirectoryName(caminho));
            Console.WriteLine("GetFileName: "+Path.GetFileName(caminho));
            Console.WriteLine("GetExtension: "+Path.GetExtension(caminho));
            Console.WriteLine("GetFileNameWhithoutExtension: "+Path.GetFileNameWithoutExtension(caminho));
            Console.WriteLine("GetFullPath: "+Path.GetFullPath(caminho));

            Console.ReadLine();
        }
    }
}
