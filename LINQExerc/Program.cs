using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;
using LINQExerc.Entities;
namespace LINQExerc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full path: ");
            string path = Console.ReadLine();
            Console.Write("Enter salary: ");
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            List<Employee> lista = new List<Employee>();
            using (StreamReader sr = File.OpenText(path))
            {
                while(!sr.EndOfStream)
                {
                    string[] empl = sr.ReadLine().Split(',');
                    double money = double.Parse(empl[2],  CultureInfo.InvariantCulture);
                    lista.Add(new Employee(empl[0], empl[1], money));
                }
            }

            var salarioMaior = lista.Where(p => p.Salary > 2000.00).OrderBy(p=> p.Email).Select(p => p.Email);
            Console.WriteLine("Email of people whose salary is more than 2000.00:");
            foreach(string email in salarioMaior)
            {
                Console.WriteLine(email);
            }
            var sum = (from p in lista where p.Name[0] == 'M' select p.Salary).Sum();
            //outra alternativa
            //var sum = list.Where(obj => obj.Name[0] == 'M').Sum(obj => obj.Salary);

            Console.WriteLine("Sum os salary of people whose name starts with 'M': " +sum);
            

            Console.ReadLine();
        }
    }
}
