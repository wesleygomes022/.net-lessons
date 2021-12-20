using System;
using System.Globalization;
using TestProj.Entities;
using TestProj.Entities.Enum;


namespace TestProj
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker w1 = new Worker();
            Console.Write("Enter department's name: ");
            string temp = Console.ReadLine();
            Department dptm = new Department { Name = temp };
            w1.Department = dptm;
            Console.WriteLine("Enter worker data: ");
            Console.Write("Name: ");            
            w1.Name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            w1.Level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base Salary: ");
            w1.BaseSalary = double.Parse(Console.ReadLine());
           
            Console.Write("How many contracts to this worker: ");
            int qtdContracts = int.Parse(Console.ReadLine());

            Console.WriteLine("----------------");

            for(int i = 1; i <= qtdContracts; i++)
            {
                HourContract h = new HourContract();
                Console.Write($"Enter #{i} contract data: (MM/DD/YYYY): ");
                h.Date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per Hour: ");
                h.ValuePerHour = double.Parse(Console.ReadLine());
                Console.Write("Duration: ");
                h.Hours = int.Parse(Console.ReadLine());
                w1.Contracts.Add(h);
            }

            Console.WriteLine("======================================");

            int month, year;
            string date;
            Console.Write("Enter month and year to calculate income (MM/YYYY):");
            date = Console.ReadLine();
            month = int.Parse(date.Substring(0, 2));
            year = int.Parse(date.Substring(3));
            Console.WriteLine("Name: " + w1.Name);
            Console.WriteLine("Deparment: " + w1.Department.Name);

            double income = w1.Income(year, month);
            Console.WriteLine($"Income for {date}: ${income}.");
        }      
    }
}
