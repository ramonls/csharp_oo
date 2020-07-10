using System;
using System.Globalization;
using System.Security.Cryptography;

namespace InterfaceIComparable.Entities
{
    class Employee: IComparable
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        //construtor
        public Employee(string csvEmployee)
        {
            string[] vect = csvEmployee.Split(',');
            Name = vect[0];
            Salary = double.Parse(vect[1], CultureInfo.InvariantCulture);
        }

        public override string ToString()
        {
            return Name + ", " + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(object obj)
        {
            //verificar se o obj é do tipo Employee
            if(!(obj is Employee))
            {
                throw new ArgumentException("Comparing error: argument is not an Employee");
            }
            //Fazendo um downcasting
            Employee other = obj as Employee;
            //Aqui estamos usando o ComparteTo da classe string, pois o nome do funcionário é do tipo string
            return Name.CompareTo(other.Name);
        }
    }
}
