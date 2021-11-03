using System;

namespace TestProj
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            int res;
            TimesThree(n, out res);
            Console.WriteLine(res);
        }

        public static void TimesThree(int n, out int result)
        {
            result = n*3;
        }
    }
}
