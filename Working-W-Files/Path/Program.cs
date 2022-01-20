using System;
using System.IO;
using System.Collections.Generic;

namespace TestProj
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\temp\Notes\Note1.txt";

            Console.WriteLine("Directory name: " + Path.GetDirectoryName(path));
            Console.WriteLine("Extension: " + Path.GetExtension(path));
            Console.WriteLine("File name: " + Path.GetFileName(path));
            Console.WriteLine("File name without extension: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("Full path: " + Path.GetFullPath(path));
            Console.WriteLine("Temp path:  " + Path.GetTempPath());
            Console.WriteLine("Directory Separator: " + Path.DirectorySeparatorChar);
            Console.WriteLine("Path separator: " + Path.PathSeparator);
        }
    }
}
