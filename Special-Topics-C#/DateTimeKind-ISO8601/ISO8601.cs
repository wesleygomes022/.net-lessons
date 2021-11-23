using System;
using System.Globalization;

 namespace TestProj
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = DateTime.Parse("2021-11-23 23:40:30");
            DateTime d2 = DateTime.Parse("2021-11-23T22:40:30Z");

            Console.WriteLine("d1: " + d1);
            Console.WriteLine("d1 Kind: " + d1.Kind);
            Console.WriteLine("d1 Local: " + d1.ToLocalTime());
            Console.WriteLine("d1 Utc: " + d1.ToUniversalTime());
            
            Console.WriteLine("---------------");

            Console.WriteLine("d2: " + d2);
            Console.WriteLine("d2 Kind: " + d2.Kind);
            Console.WriteLine("d2 Local: " + d2.ToLocalTime());
            Console.WriteLine("d2 Utc: " + d2.ToUniversalTime());

            Console.WriteLine("---------------");
            Console.WriteLine(d2.ToString("yyyy-MM-ddTHH:mm:ssZ"));//attention: INCORRECT WAY
            Console.WriteLine(d2.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ"));
        }        
    }
}
