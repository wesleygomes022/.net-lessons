﻿using System;
using System.Collections.Generic;
using Studies.Entities;
using System.Linq;

namespace Studies
{
    class Program
    {
        public static void PrintResult<T>(string msg, IEnumerable<T> collection)    
        {
            Console.WriteLine(msg);
            List<T> list = collection.ToList();
            foreach(T el in list)
            {
                Console.WriteLine(el);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 2 };
            Category c2 = new Category() { Id = 2, Name = "Computers", Tier = 1 };
            Category c3 = new Category() { Id = 3, Name = "Electronics", Tier = 1 };

            List<Product> products = new List<Product>() {
                new Product() { Id = 1, Name = "Computer", Price = 1100.0, Category = c2 },
                new Product() { Id = 2, Name = "Hammer", Price = 90.0, Category = c1 },
                new Product() { Id = 3, Name = "TV", Price = 1700.0, Category = c3 },
                new Product() { Id = 4, Name = "Notebook", Price = 1300.0, Category = c2 },
                new Product() { Id = 5, Name = "Saw", Price = 80.0, Category = c1 },
                new Product() { Id = 6, Name = "Tablet", Price = 700.0, Category = c2 },
                new Product() { Id = 7, Name = "Camera", Price = 700.0, Category = c3 },
                new Product() { Id = 8, Name = "Printer", Price = 350.0, Category = c3 },
                new Product() { Id = 9, Name = "MacBook", Price = 1800.0, Category = c2 },
                new Product() { Id = 10, Name = "Sound Bar", Price = 700.0, Category = c3 },
                new Product() { Id = 11, Name = "Level", Price = 70.0, Category = c1 }
            };

            IEnumerable<Product> r1 = products.Where((p) => p.Category.Tier == 1 && p.Price < 900);
            PrintResult("TIER 1 AND PRICE < 900:", r1);

            var r2 = products.Where((p) => p.Category.Tier == 2).Select((p) => p.Name);
            PrintResult("NAMES OF PRODUCTS FROM TOOLS:", r2);

            //using the concept of anonymous object
            var r3 = products.Where((p) => p.Name[0] == 'C').Select((p) => new { p.Name, p.Price, categoryName = p.Category.Name});
            PrintResult("NAMES OF PRODUCT WITH FIRST LETTER 'C':", r3);

            var r4 = products.Where((p) => p.Category.Tier == 1).OrderBy((p) => p.Price).ThenBy((p) => p.Name);
            PrintResult("NAMES OF PRODUCT WITH TIER 1:", r4);

            var r5 = r4.Skip(2).Take(4);
            PrintResult("SAMPLE OF SKIP/TAKE", r5);

            var r6 = products.FirstOrDefault();
            Console.WriteLine("FIRST OR DEFAULT: " + r6);

            var r7 = products.Where((p) => p.Price >= 5000).FirstOrDefault();
            Console.WriteLine("First or default for elem >= $3000: " + r7);

            Console.WriteLine();

            var r8 = products.Where((p) => p.Id == 3).SingleOrDefault();
            Console.WriteLine("Single or default Test #1: " + r8);

            var r9 = products.Where((p) => p.Id == 324).SingleOrDefault();
            Console.WriteLine("\nSingle or default Test #2: " + r9);

            var r10 = products.Max((p) => p.Price);
            Console.WriteLine("Max price: " + r10);

            var r11 = products.Min((p) => p.Price);
            Console.WriteLine("Min price: " + r11);

            var r12 = products.Where((p) => p.Category.Id == 1).Sum((p) => p.Price);
            Console.WriteLine("Category 1 sum prices: " + r12);

            var r13 = products.Where((p) => p.Category.Id == 1).Average(p => p.Price);
            Console.WriteLine("Average price: " + r13);

            var r14 = products.Where(p => p.Category.Id == 5).Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine("Average price: " + r14);

            var r15 = products.Where(p => p.Category.Id == 1).Select(p => p.Price).Aggregate((x, y) => x + y);
            Console.WriteLine("Category 1 aggregate sum: " + r15);
            Console.WriteLine();

            var r16 = products.GroupBy(p => p.Category);
            foreach(IGrouping<Category, Product> group in r16)
            {
                Console.WriteLine("Category" + group.Key.Name + ":");
                foreach(Product p in group)
                {
                    Console.WriteLine(p);
                }
                Console.WriteLine();
            }

        }
    }
}