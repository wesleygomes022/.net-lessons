using System;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "Wesley";
            int idade = 21;
            double salario = 2280.35232;

            //placeholder
            Console.WriteLine("{0} tem {1} anos e salario de {2:F2} reais.", nome, idade, salario);

            //interpolação
            Console.WriteLine($"{nome} tem {idade} anos e salario de {salario:F2} reais.");

            //concatenação
            Console.WriteLine(nome + " tem " + idade + " anos e salario de " + salario.ToString("F2") + " reais.");
        }
    }
}
