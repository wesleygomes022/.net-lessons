using System;
using System.Collections.Generic;
using TestProj.Entities;
using TestProj.Entities.Enum;

namespace TestProj
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> list = new List<Shape>();

            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"\nShape #{i} data: ");
                Console.Write("Rectangle or Cicle (r/c)? ");
                char sFormat = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red)? ");
                string color = Console.ReadLine();

                if(sFormat == 'r')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine());
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine());

                    list.Add(new Rectangle(Enum.Parse<Color>(color), width, height));
                }
                else
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine());

                    list.Add(new Circle(Enum.Parse<Color>(color), radius));
                }   

            }

            Console.WriteLine("\nSHAPE AREAS: ");
            foreach (Shape el in list)
            {
                Console.WriteLine(el.Area().ToString("F2"));
            }
        }
    }
}
