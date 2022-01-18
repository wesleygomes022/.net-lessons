using System;
using System.IO;
using System.Collections.Generic;

namespace TestProj
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileA = @"C:\temp\fileA.txt";

            try
            {
                FileStream fs = new FileStream(fileA, FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                List<string> list = new List<string>();
                while(!sr.EndOfStream)
                {
                    list.Add(sr.ReadLine());
                }
                
                foreach(string el in list)
                {
                    Console.WriteLine(el);
                }

            }
            catch(IOException e)
            {
                Console.WriteLine("Ops... An error occured: " + e.Message);
            }
            
        }
    }
}
