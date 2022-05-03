using System;
using System.Collections.Generic;

namespace Studies
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            list.Add(new Product("TV", 1399.87));
            list.Add(new Product("Radio", 487.99));
            list.Add(new Product("Iphone", 14000.78));

            list.Sort(Compare);

            foreach(Product el in list)
            {
                Console.WriteLine(el);
            }
        }

        static int Compare(Product p1, Product p2)
        {
            return p1.Price.CompareTo(p2.Price);
        }
    }
}
