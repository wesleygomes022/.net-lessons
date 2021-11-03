using System;

namespace TestProj
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = new string[] { "banana", "limao", "pera", "melancia", "abacaxi" };

            foreach(string fruta in arr)
            {
                Console.WriteLine(fruta);
            }
        }
    }
}
