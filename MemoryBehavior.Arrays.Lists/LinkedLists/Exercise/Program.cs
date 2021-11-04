using System;
using System.Collections.Generic;

namespace TestProj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employees will be registered? ");
            int numEmployees = int.Parse(Console.ReadLine());

            List<Employee> list = new List<Employee>();

            for(int i = 1; i <= numEmployees; i++)
            {

                Console.Write("\nEmployee #" + i + "\n");
                Console.Write("Id: ");
                int idTemp = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine());
                list.Add(new Employee(idTemp, name, salary));

            }

            Console.WriteLine("");

            foreach (Employee el in list)
            {
                Console.WriteLine(el);
                Console.WriteLine("------------------------------");
            }

            Console.Write("\nEnter the employee id that will have salary increase: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Enter the percentage: ");
            double percentage = double.Parse(Console.ReadLine());                    
                        
            Employee search = list.Find(em => em.Id == id);

            if(search != null)
            {
                search.IncreaseSalary(percentage);
            }
            else
            {
                Console.WriteLine("\n\nThis user don't exist.\n\n");
            }

            Console.WriteLine("");

            foreach(Employee el in list)
            {
                Console.WriteLine(el);
                Console.WriteLine("------------------------------");
            }
        }
    }
}
