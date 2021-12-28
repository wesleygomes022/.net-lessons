using System;
using TestProj.Entities;
using System.Collections.Generic;

namespace TestProj
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> listEmployees = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"\nEmployee #{i} data:");
                Console.Write("Outsourced (y/n): ");
                char outSourced = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine());

                if (outSourced == 'n')
                {       
                    listEmployees.Add(new Employee(name, hours, valuePerHour));
                }
                else
                {
                    Console.Write("Additional charge: ");
                    double addCharge = double.Parse(Console.ReadLine());

                    listEmployees.Add(new OutSourcedEmployee(name, hours, valuePerHour, addCharge));
                }                      
            }

            Console.WriteLine("\nPAYMENTS:");
            foreach(Employee em in listEmployees)
            {
                Console.WriteLine($"{em.Name} - ${em.Payment()}");
            }
        }
    }
}
