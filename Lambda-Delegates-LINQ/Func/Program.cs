using System;
using System.Collections.Generic;
using System.Linq;

namespace Studies
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            //Other way of implementation
            //Func<Product, string> temp = p => p.Name.ToUpper();
            //List<string> banana = list.Select(temp).ToList();

            List<String> result = list.Select(p => p.Name.ToUpper()).ToList();

            foreach (string el in result)
            {
                Console.WriteLine(el);
            }
        }
    }
}