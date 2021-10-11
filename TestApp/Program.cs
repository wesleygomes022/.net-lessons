using System;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = double.Parse(Console.ReadLine());

            //imprimindo valor double com delimitação de 2 dígitos após a vírgula
            Console.WriteLine(salario.ToString("F2"));
        }
    }
}