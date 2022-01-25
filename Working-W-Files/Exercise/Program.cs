using System;
using System.IO;
using TestProj.Entities;

namespace TestProj
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\temp\Products.txt";
            string targetPath = @"C:\temp\out";
            string targetFile = targetPath + @"\summary.csv";
            string[] arr = File.ReadAllLines(filePath);
            Directory.CreateDirectory(targetPath);
            try
            {
                using(StreamWriter rs = File.AppendText(targetFile))
                {
                    foreach(string el in arr)
                    {
                        string[] arr2 = el.Split(",");
                        Product p = new Product(arr2[0], double.Parse(arr2[1]), double.Parse(arr2[2]));
                        rs.WriteLine($"{p.Name},{p.TotalPrice()}");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
