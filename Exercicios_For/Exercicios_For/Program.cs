using System;
using System.Globalization;

namespace Exercicios_For
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problema Média Ponderada
            Console.Write("Digite a quantidade de amostras: ");
            int n = int.Parse(Console.ReadLine());
            double media;

            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split(' ');
                double a = double.Parse(line[0], CultureInfo.InvariantCulture);
                double b = double.Parse(line[1], CultureInfo.InvariantCulture);
                double c = double.Parse(line[2], CultureInfo.InvariantCulture);
                media = (a * 2 + b * 3 + c * 5) / 10;

                Console.WriteLine("Média Ponderada: " + media.ToString("F1", CultureInfo.InvariantCulture));
            }

        }
    }
}


/*
            //Problemas ímpares até 'x'
            Console.Write("Informe um valor inteiro (1 < 'X' < 100): ");
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i <= x; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }

 */


/*//Problema in/out intervalo
            Console.Write("Informe um valor inteiro (1 < 'N' < 100): ");
            int N = int.Parse(Console.ReadLine());
            int somaIn = 0;
            int somaOut = 0;
            Console.WriteLine();

            for (int i = 1; i <= N; i++)
            {
                Console.Write("Valor #" + i + " = ");
                int valor = int.Parse(Console.ReadLine());
                if (valor >= 10 && valor <= 20)
                {
                    somaIn += 1;
                }
                else
                {
                    somaOut += 1;
                }
            }

            Console.WriteLine(somaIn + " In");
            Console.WriteLine(somaOut + " Out");
*/
