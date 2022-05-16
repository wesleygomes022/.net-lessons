using System;
using System.Collections.Generic;

namespace Studies
{
    delegate void Operation(double x, double y);
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            //list.RemoveAll((el) => el.Price <= 300);
            int n = list.RemoveAll(ProductTest);

            foreach(Product el in list)
            {
                Console.WriteLine(el);
            }

            Console.WriteLine(n);
        }

        public static bool ProductTest(Product p)
        {
            return p.Price <= 300;
        }
    }
}
