using System;
using System.Globalization;

 namespace TestProj
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = new DateTime(2021, 11, 17, 11, 30, 45, 300);
            Console.WriteLine(d1.Date);
            Console.WriteLine(d1.Day);
            Console.WriteLine(d1.DayOfWeek);
            Console.WriteLine(d1.DayOfYear);
            Console.WriteLine(d1.Hour);
            Console.WriteLine(d1.Kind);
            Console.WriteLine(d1.Millisecond);
            Console.WriteLine(d1.Minute);
            Console.WriteLine(d1.Month);
            Console.WriteLine(d1.Second);
            Console.WriteLine(d1.Ticks);
            Console.WriteLine(d1.TimeOfDay);
            Console.WriteLine(d1.Year);

            Console.WriteLine(d1.ToLongDateString());
            Console.WriteLine(d1.ToLongTimeString());
            Console.WriteLine(d1.ToShortDateString());
            Console.WriteLine(d1.ToShortTimeString());

            Console.WriteLine(d1.ToString());

            Console.WriteLine(d1.ToString("yyyy-MM-dd HH:mm:ss"));
            Console.WriteLine(d1.ToString("yyyy-MM-dd HH:mm:ss.fff"));
        }        
    }
}
