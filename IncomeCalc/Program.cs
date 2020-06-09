using System;
using System.Collections.Generic;
using IncomeCalc.Entities.Enums;
using IncomeCalc.Entities;
using System.Globalization;
using System.Diagnostics.Contracts;

namespace IncomeCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter departament's name: ");
            string deptName = Console.ReadLine();
            Console.WriteLine("Enter worker data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            //uma variável do tipo WorkerLevel que é o nosso enum, irá receber, porém será preciso ser convertida de string para WorkerLevel
            WorkerLevel level = (WorkerLevel) Enum.Parse(typeof (WorkerLevel), Console.ReadLine());
            Console.Write("Base Salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Instâncias
            //Instanciar o objeto departamento
            Departament dept = new Departament(deptName);

            //Instanciar o objeto Worker
            Worker worker = new Worker(name, level, baseSalary, dept);

            Console.Write("How many contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                //Vamos usar a interpolação, para apresentação da variável no texto, por isso usamos $ no inicio
                Console.WriteLine($"Enter #{i} contract data:");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine()); //Convertendo para o formato DateTime
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());

                //Depois do usuário digitar os dados do contrato, vamos instanciar o contrato
                HourContract contract = new HourContract(date, valuePerHour, hours);

                //Agora vamos adicionar o contrato ao trabalhador
                worker.AddContract(contract);
                //---------------------------------------------------------------------
            }
                Console.WriteLine("");
                Console.Write("Enter month and year to calculate income (MM/YYYY): ");
                //vamos guardar o mes e ano em uma string, depois vamos recortar a string nas posições desejadas
                string monthAndYear = Console.ReadLine();
                int month = int.Parse(monthAndYear.Substring(0, 2));
                int year = int.Parse(monthAndYear.Substring(3, 4)); //se colocar só o 3 ele corta do 3 em diantes, outra forma de fazer

                Console.WriteLine("Name: "+worker.Name);
                Console.WriteLine("Departament: "+worker.Departament.Name);
                Console.WriteLine("Income for "+monthAndYear+": "+worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture));
                Console.ReadLine();

        }
    }
}
