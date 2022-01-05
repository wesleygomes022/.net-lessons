using System;
using TestProj.Entities;
using System.Collections.Generic;

namespace TestProj
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> list = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"\nTax payer #{i} data: ");
                Console.Write("Individual or company (i/c)? ");
                char payerType = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anInc = double.Parse(Console.ReadLine());

                if(payerType == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double hExp = double.Parse(Console.ReadLine());

                    list.Add(new Individual(name, anInc, hExp));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int nEmp = int.Parse(Console.ReadLine());

                    list.Add(new Company(name, anInc, nEmp));
                }
            }

            Console.WriteLine("\nTAXES PAID:");
            double total = 0;
            foreach(TaxPayer tp in list)
            {
                total += tp.Tax();
                Console.WriteLine($"{tp.Name}: ${tp.Tax().ToString("F2")}");
            }

            Console.WriteLine($"\nTOTAL TAXES: ${total.ToString("F2")}");
        }
    }
}
