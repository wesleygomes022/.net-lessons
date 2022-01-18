using System;
using System.IO;

namespace TestProj
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileA = @"C:\temp\fileA.txt";
            try
            {
                using (StreamReader sr = File.OpenText(fileA))
                {
                    while(!sr.EndOfStream)
                    {
                        Console.WriteLine(sr.ReadLine());
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Ops... An error occured: " + e.Message);
            }
        }
    }
}
