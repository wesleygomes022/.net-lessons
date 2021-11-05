using System;

namespace TestProj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira a ordem da matrix desejada:");
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            Console.WriteLine("Insira os elementos da matriz abaixo: ");
            
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("Linha["+i+"] Coluna["+j+"] -> ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("");

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine("");
            }

            Console.WriteLine("");

            Console.WriteLine("Diagonal principal: ");

            int negative = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    if(i == j)
                    {
                        Console.Write(matrix[i, j] + " ");
                    }
                    if(matrix[i, j] < 0 )
                    {
                        negative++;
                    }
                }
            }

            Console.WriteLine("");
            Console.WriteLine("Numeros negativos: " + negative);
                        
        }
    }
}
