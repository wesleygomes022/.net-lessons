using System;
using System.IO;

namespace TestProj
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\temp\fileA.txt";
            string targetPath = @"C:\temp\fileB.txt";
            
            try
            {                
                FileInfo fi = new FileInfo(sourcePath);
                //fi.CopyTo(targetPath);
                File.Copy(sourcePath, targetPath);
                string[] lines = File.ReadAllLines(targetPath);

                foreach(string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch(IOException e)
            {
                Console.WriteLine("An error occured: " + e.Message);
            }            
        }
    }
}
