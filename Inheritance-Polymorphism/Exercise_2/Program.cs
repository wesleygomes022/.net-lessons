using System;
using System.Collections.Generic;
using TestProj.Entities;

namespace TestProj
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"\nProduct #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char pType = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());
                
                if(pType == 'i')
                {
                    Console.Write("Customs fee: ");
                    double customFee = double.Parse(Console.ReadLine());

                    list.Add(new ImportedProduct(name, price, customFee));
                }
                else if(pType == 'u')
                {
                    Console.Write("Manufacture date (MM/DD/YYYY): ");
                    DateTime manuDate = DateTime.Parse(Console.ReadLine());

                    list.Add(new UsedProduct(name, price, manuDate));
                }
                else
                {
                    list.Add(new Product(name, price));
                }
            }

            Console.WriteLine("\nPRICE TAGS:");
            
            foreach(Product el in list)
            {
                Console.WriteLine(el.PriceTag());
            }
        }
    }
}
