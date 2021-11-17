using System;
using System.Globalization;

 namespace TestProj
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = new DateTime(2021, 11, 17, 11, 30, 45, 300);

            DateTime d2 = d1.AddHours(3);

            DateTime d3 = d2.AddMinutes(5);

            TimeSpan d4 = d3.Subtract(d1);

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);

        }        
    }
}
