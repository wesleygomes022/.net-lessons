using System;
using System.IO;
using System.Collections.Generic;

namespace TestProj
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\temp";

            try
            {
                IEnumerable<string> temp = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                foreach(string el in temp)
                {
                    Console.WriteLine(el);
                }

                Console.WriteLine();

                IEnumerable<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                foreach(string el in files)
                {
                    Console.WriteLine(el);
                }

                DirectoryInfo di = Directory.CreateDirectory(path + @"\Wesley");
                Console.WriteLine();
                Console.WriteLine(di);
            }
            catch(IOException e)
            {
                Console.WriteLine(e.Message);
            }

            
        }
    }
}
