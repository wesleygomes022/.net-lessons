using System;
using System.Globalization;

 namespace TestProj
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = DateTime.Now;
            Console.WriteLine(d1);
            Console.WriteLine(d1.Ticks);

            DateTime d2 = new DateTime(2021, 11, 16);
            DateTime d3 = new DateTime(2021, 11, 16, 16, 28, 15);
            DateTime d4 = new DateTime(2021, 11, 16, 16, 29, 15, 900);

            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);

            DateTime d5 = DateTime.Now;
            Console.WriteLine(d5);

            DateTime d6 = DateTime.Today;
            Console.WriteLine(d6);

            DateTime d7 = DateTime.UtcNow;
            Console.WriteLine(d7);

            DateTime d8 = DateTime.Parse("2021-11-16");
            Console.WriteLine(d8);

            DateTime d9 = DateTime.Parse("2021/11/16 16:41:30");
            Console.WriteLine(d9);

            DateTime d10 = DateTime.ParseExact("16/11/2021", "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine(d10);

            DateTime d11 = DateTime.ParseExact("16-11-2021 16:52:30", "dd-MM-yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            Console.WriteLine(d11);
        }        
    }
}
