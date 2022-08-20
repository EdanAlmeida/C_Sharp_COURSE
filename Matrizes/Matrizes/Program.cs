using System;

namespace Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Activity Square array
            Console.Write("Enter the array number: ");
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];

            int soma = 0;

            for (int i = 0; i < n; i++)
            {
                //string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    Console.Write("Enter the value of row #" + i + " Column #" + j + ": ");
                    mat[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(mat[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Main Diagonal: ");

            for (int i = 0; i < n; i++)
            {
                Console.Write(mat[i, i] + " ");
            }

            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] < 0)
                    {
                        soma ++;
                    }
                }
            }
            Console.WriteLine("Negative Numbers: " + soma);
            

        }
    }
}

/*
            double[,] mat = new double[2, 3];
            Console.WriteLine(mat.Length);
            Console.WriteLine(mat.Rank);
            Console.WriteLine(mat.GetLength(0));//linhas
            Console.WriteLine(mat.GetLength(1));//colunas
 */

