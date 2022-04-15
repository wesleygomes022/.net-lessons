using System;
using System.Collections.Generic;
using System.IO;
using TestProj.Entities;

namespace TestProj
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = @"C:\temp\logs.txt";
            HashSet<Log> hashTable = new HashSet<Log>();
            using (StreamReader sr = File.OpenText(file))
            {
                while (!sr.EndOfStream)
                {
                    string[] temp = sr.ReadLine().Split(' ');
                    Log tempLog = new Log(temp[0], temp[1]);
                    hashTable.Add(tempLog);
                }
            }

            Console.WriteLine(hashTable.Count);
        }
    }
}
