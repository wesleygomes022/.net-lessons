using System;
using System.Collections.Generic;
using TestProj.Entities;

namespace TestProj
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Product> a = new HashSet<Product>();
            a.Add(new Product("TV", 900.00));
            a.Add(new Product("Notebook", 1200.00));

            Product prod = new Product("Notebook", 1200.00);
            
            //this first validation should return false, since the class Product don't 
            //implement GetHashCode and Equals methods. Therefore, the method Contains 
            //will validate both objects using memory referencing.
            //After implement those methods said above, the method Contains may make the 
            //validation using value comparison, then the result will be true.
            //You can test this behavior by commenting and discommenting the Equals and 
            //GetHashCode methods implementation in the Product class and checking the 
            //result.
            Console.WriteLine(a.Contains(prod));

            HashSet<Point> b = new HashSet<Point>();
            b.Add(new Point(3, 4));
            b.Add(new Point(5, 10));

            Point point = new Point(3, 4);

            //this time, the return will be true. When the data type is a struct,
            //the Contains function makes the comparison using through the value, 
            //not the reference. Therefore, it's not necessary implement GetHashCode
            //and Equals in the struct class. 
            Console.WriteLine(b.Contains(point));

        }       
    }
}
