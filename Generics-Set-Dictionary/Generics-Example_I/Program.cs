using System;

namespace TestProj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many values? ");
            int size = int.Parse(Console.ReadLine());

            PrintService<string> ps = new PrintService<string>(3);
            for(int i=0; i<size; i++)
            {
                string temp = Console.ReadLine();
                ps.AddValue(temp);
            }

            int x = int.Parse(ps.First());

            ps.Print();
            Console.WriteLine("\nFirst: " + ps.First());

        }
    }
}
