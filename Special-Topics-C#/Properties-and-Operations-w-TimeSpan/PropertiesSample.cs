using System;
using System.Globalization;

 namespace TestProj
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan t1 = new TimeSpan(2, 3, 5, 7, 101);
            Console.WriteLine(t1.Days);
            Console.WriteLine(t1.Hours);
            Console.WriteLine(t1.Minutes);
            Console.WriteLine(t1.Seconds);
            Console.WriteLine(t1.Milliseconds);
            Console.WriteLine(t1.Ticks);

            Console.WriteLine("---------------");

            Console.WriteLine(t1.TotalDays);
            Console.WriteLine(t1.TotalHours);
            Console.WriteLine(t1.TotalMinutes);
            Console.WriteLine(t1.TotalSeconds);
            Console.WriteLine(t1.TotalMilliseconds);
        }        
    }
}
