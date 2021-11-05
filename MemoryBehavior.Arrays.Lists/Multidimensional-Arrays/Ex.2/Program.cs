using System;

namespace TestProj
{
    class Program
    {
        static void Main(string[] args)
        {

            int linhas;
            int colunas;
            Console.Write("Qual o numero de linhas: ");
            linhas = int.Parse(Console.ReadLine());
            Console.Write("Qual o numero de colunas: ");
            colunas = int.Parse(Console.ReadLine());

            int[,] matrix = new int[linhas, colunas];

            for(int i = 0; i < linhas; i++)
            {
                string[] temp = Console.ReadLine().Split(" ");
                for(int j = 0; j < colunas; j++)
                {
                    matrix[i, j] = int.Parse(temp[j]);
                }
            }

            Console.WriteLine("");

            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    Console.Write("\t" + matrix[i, j]);
                }
                Console.WriteLine("");
            }

            Console.Write("\nInsira o No desejado: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    if(matrix[i, j] == n)
                    {
                        Console.WriteLine("Position: i = " + i + "; j = " + j);
                        if(j > 0)
                        {
                            Console.WriteLine("Left: " + matrix[i, j-1]);
                        }
                        
                        if(j <= (colunas-2))
                        {
                            Console.WriteLine("Right: " + matrix[i, j+1]);
                        }

                        if(i > 0)
                        {
                            Console.WriteLine("Up: " + matrix[i-1, j]);
                        }

                        if(i < (linhas-1))
                        {
                            Console.WriteLine("Down: " + matrix[i+1, j]);
                        }
                        Console.WriteLine("-----------------------------------");
                    }
                }
            }

        }      
    }
}
