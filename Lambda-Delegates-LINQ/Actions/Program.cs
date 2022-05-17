using System;
using System.Collections.Generic;

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

            //Other ways to use Action:
            //list.ForEach((p) => { p.Price += p.Price * 0.1; });
            //list.ForEach(AddPrice);
            Action<Product> action = p => p.Price += p.Price*0.1;
            list.ForEach(action);
            

            foreach (Product el in list)
            {
                Console.WriteLine(el);
            }
        }

        //It's possible to implement a function and use it
        //as a Action predicate.
        public static void AddPrice(Product p)
        {
            p.Price += p.Price * 0.1;
        }
    }
}
