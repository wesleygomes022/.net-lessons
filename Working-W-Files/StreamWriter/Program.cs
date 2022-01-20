using System;
using System.IO;

namespace TestProj
{
    class Program
    {
        static void Main(string[] args)
        {
            //string sourcePath = @"C:\temp\fileA.txt";
            string targetPath = @"C:\temp\fileB.txt";
            string[] str = new string[] { "Wesley de Paiva", "22 anos", "São Paulo, Brasil" };

            try
            {
                using (FileStream fs = new FileStream(targetPath, FileMode.OpenOrCreate))
                {
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            sw.WriteLine(str[i]);
                        }
                    }
                }
            }
            catch(IOException e)
            {
                Console.WriteLine("An error occured: " + e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
