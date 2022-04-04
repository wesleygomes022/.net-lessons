using System;
using System.IO;

namespace TestProj
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = @"C:\names.txt";
            Employee[] arr = new Employee[9];
            using(StreamReader sr = File.OpenText(file))
            {
                int acc = 0;
                while(!sr.EndOfStream)
                {
                    arr[acc] = new Employee(sr.ReadLine());
                    acc++;
                }
            }

            Array.Sort(arr);

            foreach(Employee el in arr)
            {
                Console.WriteLine(el);
            }
        }
    }
}
