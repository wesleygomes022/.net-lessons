using System;
using System.Collections.Generic;
using TestProj.Entities;
using TestProj.Services;

namespace TestProj
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            Console.Write("Enter N:");
            int n = int.Parse(Console.ReadLine());
            for(int i=0; i<n; i++)
            {
                string[] temp = Console.ReadLine().Split(',');
                list.Add(new Product(temp[0], double.Parse(temp[1])));
            }

            Console.Write("Most expensive: \n" + CalculationService.Max(list));

        }
    }
}
