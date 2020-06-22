using ProdExerc.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ProdExerc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of products: ");
            int numberProducts = int.Parse(Console.ReadLine());

            List<Product> product = new List<Product>();
            for(int i = 1; i <= numberProducts; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                string condition = Console.ReadLine();
                if(condition == "c" || condition == "C")
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    product.Add(new Product(name, price));
                }
                if(condition == "u" || condition == "U")
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                    product.Add(new UsedProduct(name, price, manufactureDate));
                }
                if(condition == "i" || condition == "I")
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    product.Add(new ImportedProduct(name, price, customsFee));
                }

            }
            Console.WriteLine("");
            Console.WriteLine("Price Tags:");
            foreach(Product prod in product)
            {
                Console.WriteLine(prod.PriceTag());
            }

            Console.ReadLine();

        }
    }
}
