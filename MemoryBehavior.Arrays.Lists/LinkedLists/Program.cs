using System;
using System.Collections.Generic;

namespace TestProj
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<string> list = new List<string> { "Banana", "Apple", "Pineapple" };

            //insert element in the end of the list
            list.Add("Watermelon");

            foreach (string el in list)
            {
                Console.WriteLine(el);
            }

            //insert element after index
            list.Insert(1, "Grape");
            list.Add("Asparagus");

            Console.WriteLine("---------------------");

            foreach (string el in list)
            {
                Console.WriteLine(el);
            }

            Console.WriteLine("---------------------");

            //return the number of elements in the list
            Console.WriteLine("List Count: " + list.Count);

            Console.WriteLine("---------------------");

            Console.WriteLine("First 'A': " + list.Find(s => s[0] == 'A'));

            Console.WriteLine("---------------------");

            //using Lambda expression for Find method
            Console.WriteLine("First 'P': " + list.Find(s => s[0] == 'P'));

            Console.WriteLine("---------------------");
            List<string> list2 = list.FindAll(Test);

            foreach(string el in list2)
            {
                Console.WriteLine(el);
            }

            Console.WriteLine("---------------------");

            Console.WriteLine("Last 'A': " + list.FindLast(s => s[0] == 'A'));

            Console.WriteLine("---------------------");

            Console.WriteLine("Last Position 'A': " + list.FindLastIndex(s => s[0] == 'A'));

            Console.WriteLine("---------------------");

            list.Remove("Watermelon");
            foreach(string el in list)
            {
                Console.WriteLine(el);
            }

            Console.WriteLine("---------------------");

            list.RemoveAll(s => s[s.Length-1] == 'e');

            foreach (string el in list)
            {
                Console.WriteLine(el);
            }

            Console.WriteLine("---------------------");

            list.RemoveAt(0);
            foreach (string el in list)
            {
                Console.WriteLine(el);
            }

            Console.WriteLine("---------------------");

            list.Add("Blackberries");
            list.Add("Avocado");
            list.Add("Cantaloupe");
            list.Add("Coconut Meat");
            list.Add("Cranberries");

            foreach(string el in list)
            {
                Console.WriteLine(el);
            }
            
            Console.WriteLine("---------------------");

            list.RemoveRange(3, 3);
            foreach (string el in list)
            {
                Console.WriteLine(el);
            }

        }

        //sample of a Predicate 
        static bool Test(string s)
        {
            return s[0] == 'A';
        }
    }
}
