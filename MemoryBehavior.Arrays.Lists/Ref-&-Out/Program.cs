using System;

namespace TestProj
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            TimesThree(ref n);
            Console.WriteLine(n);
        }

        public static void TimesThree(ref int n)
        {
            n *= 3;
        }
    }
}
