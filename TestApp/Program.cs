using System;
namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();

            Console.Write("Insira o nome da 1a pessoa: ");
            p1.setNome(Console.ReadLine());

            Console.Write("Insira a idade da 1a pessoa: ");
            p1.setIdade(int.Parse(Console.ReadLine()));

            Console.WriteLine();

            Console.Write("Insira o nome da 2a pessoa: ");
            p2.setNome(Console.ReadLine());

            Console.Write("Insira a idade da 2a pessoa: ");
            p2.setIdade(int.Parse(Console.ReadLine()));

            string pMaisVelha = Pessoa.pVelha(p1, p2);

            Console.WriteLine("\nA Pessoa mais velha é: " + pMaisVelha);


        }
    }
}