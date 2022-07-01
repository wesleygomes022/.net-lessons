using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Studies
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();
            string path = @"C:\projects\.net projects\ws-vs2019\Studies\TextFile1.txt";

            using(StreamReader sr = File.OpenText(path))
            {
                while(!sr.EndOfStream)
                {
                    string[] temp = sr.ReadLine().Split(',');
                    list.Add(new Employee(temp[0], temp[1], double.Parse(temp[2])));
                }
            }

            Console.Write("Enter salary: ");
            double salary = double.Parse(Console.ReadLine());

            Console.WriteLine("Email of people whose salary is more than " 
                + salary.ToString("F2") 
                + ":");

            var emails = list.Where(p => p.Salary > 2000)
                .OrderBy(p => p.Email)
                .Select(p => p.Email);
            foreach(string email in emails)
            {
                Console.WriteLine(email);
            }

            double sumSalary = list.Where(p => p.Name[0].CompareTo('M') == 0)
              .Sum(p => p.Salary);

            /*double sumSalary = list.Where(p => p.Name[0] == 'M') 
                .Sum(p => p.Salary);*/

            Console.WriteLine("Sum of salary of people whose name starts with 'M': "
                + sumSalary);

        }
    }
}