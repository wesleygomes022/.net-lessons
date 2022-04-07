using System;
//using System.Collections.Generic;

namespace TestProj
{
    class PrintService<T>
    {
        private T[] Values { get; set; }
        private int Count { get; set; } = 0;

        public PrintService(int size)
        {
            Values = new T[size];
        }

        public void AddValue(T num)
        {
            if (Count == Values.Length)
            {
                throw new Exception("Buffer is full.");
            }                
            else
            {
                Values[Count] = num;
                Count++;
            }
        }

        public T First()
        {
            if (Count == 0)
                throw new Exception("Buffer is empty.");
            else
                return Values[0];
        }

        public void Print()
        {
            Console.Write("[");
            for(int i = 0; i < Values.Length-1; i++)
            {
                Console.Write($"{Values[i]}, ");
            }
            Console.Write($"{Values[Values.Length-1]}]");
        }
    }
}
