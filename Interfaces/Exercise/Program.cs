using System;
using TestProj.Entities;
using TestProj.Services;
using System.Globalization;

namespace TestProj
{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/mm/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract value: ");
            double value = double.Parse(Console.ReadLine());
            Console.Write("Enter number of installments: ");
            int instalments = int.Parse(Console.ReadLine());

            Contract c = new Contract(number, date, value, instalments);
            ContractService contractService = new ContractService(new PayPal());
            contractService.ProcessContract(c, instalments);

            Console.WriteLine();
            c.Print();
        }
    }
}

