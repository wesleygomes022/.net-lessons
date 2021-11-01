using System;

namespace TestProj
{
    class Program
    {
        static void Main(string[] args)
        {
            //criação array do tipo classe
            Produto[] p = new Produto[3];
            for(int i=0; i<3; i++)
            {
                string nome = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine());
                p[i] = new Produto { Nome = nome, Preco = preco };
            }

            double soma = 0;

            for (int i=0; i<3; i++) 
            {
                soma += p[i].Preco;
            }

            soma /= 3;

            Console.WriteLine("Preco Medio = " + soma);
        }
    }
}
