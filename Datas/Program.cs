using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datas
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime data = DateTime.Now;
            DateTime dataNascimento = new DateTime(1985, 11, 12, 9, 30, 00);

            Console.WriteLine("Data: "+data);
            Console.WriteLine("Dia do ano: "+ data.DayOfYear);
            Console.WriteLine("Data Nascimento: "+dataNascimento.ToLongDateString());

            Console.ReadLine();
        }
    }
}
