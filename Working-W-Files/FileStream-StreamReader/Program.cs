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
            FileStream fs = null;
            StreamReader sr = null;
            List<string> list = new List<string>();

            try
            {
                fs = new FileStream(fileA, FileMode.Open);
                sr = new StreamReader(fs);                
                while (!sr.EndOfStream)
                {
                    list.Add(sr.ReadLine());
                }

                foreach (string el in list)
                {
                    Console.WriteLine(el);
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("Ops... An error occured: " + e.Message);
            }
            finally
            {
                if (fs != null)
                    fs.Close();

                if (sr != null)
                    sr.Close();
            }
        }
    }
}
