using System;

namespace Studies
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2022, 4, 25, 10, 01, 12);
            Console.WriteLine(dt.ElapsedTime());
        }
    }
}
