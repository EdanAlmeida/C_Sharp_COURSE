using System;

namespace Exercicios_For
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problema in/out intervalo
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

