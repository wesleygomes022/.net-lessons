using System;

namespace TestProj
{
    class Program
    {
        static void Main(string[] args)
        {
            //criação array do tipo struct
            int[] array = new int[10];

            for(int i=0; i<array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Array["+i+"] = " + array[i]);
            }
        }
    }
}
