using System;
using System.Collections.Generic;
using System.Linq;

namespace Studies
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 5, 6, 7, 8 };

            List<int> result = arr.Where((n) => n % 2 == 0).Select((n) => n * 10).ToList();

            foreach(int el in result)
            {
                Console.WriteLine(el);
            }
        }
    }
}