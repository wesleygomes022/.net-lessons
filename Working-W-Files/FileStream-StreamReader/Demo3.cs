using System;
using System.IO;

namespace TestProj
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileA = @"C:\temp\fileA.txt";
            StreamReader sr = null;

            try
            {
                sr = File.OpenText(fileA);                
                while (!sr.EndOfStream)
                {
                    Console.WriteLine(sr.ReadLine());
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("Ops... An error occured: " + e.Message);
            }
            finally
            {
                if (sr != null)
                    sr.Close();
            }
        }
    }
}
