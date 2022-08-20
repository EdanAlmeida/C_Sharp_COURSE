using System;

namespace Exercicio_Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of rows: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Enter the number of columns: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter the value of 'X': " );
            int x = int.Parse(Console.ReadLine());

            int[,] mat = new int[m, n]; //criação e instanciação da matriz

            //for para armazenar os valores na matriz
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("Enter row #" + i + ", column #" + j + ": ");
                    mat[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine();
            //for para printar os valores na tela
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(mat[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }

            //for para verificar a exixtência do valor estipulado para x dentro da matriz
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] == x)
                    {
                        Console.WriteLine("Position: " + i + ", " + j);
                        if (i > 0)
                        {
                            Console.WriteLine("UP: " + mat[i - 1, j]);
                        }
                        if (i < m - 1)
                        {
                            Console.WriteLine("DOWN " + mat[i + 1, j]);
                        }
                        if (j > 0)
                        {
                            Console.WriteLine("LEFT: " + mat[i, j - 1]);
                        }
                        if (j < n - 1)
                        {
                            Console.WriteLine("RIGHT: " + mat[i, j + 1]);
                        }
                    }
                }
            }
        }
    }
}
