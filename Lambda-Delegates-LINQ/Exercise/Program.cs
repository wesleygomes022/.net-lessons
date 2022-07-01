using System;
using System.IO;
using System.Collections.Generic;
using Studies.Entities;
using System.Linq;

namespace Studies
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\projects\.net projects\ws-vs2019\Studies\TextFile1.txt";
            List<Product> list = new List<Product>();
            using(StreamReader sr = File.OpenText(path))
            {
                while(!sr.EndOfStream)
                {
                    string[] split = sr.ReadLine().Split(',');
                    list.Add(new Product(split[0], double.Parse(split[1])));
                }
            }

            double average = list.Sum(p => p.Price) / list.Count;
            Console.WriteLine("Average price: " + average.ToString("F2"));

            var order = list.Where(p => p.Price < average).OrderByDescending(p => p.Name);
            foreach(Product el in order)
            {
                Console.WriteLine(el.Name);
            }
        }
    }
}