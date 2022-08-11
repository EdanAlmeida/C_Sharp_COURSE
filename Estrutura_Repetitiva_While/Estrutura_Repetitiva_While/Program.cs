using System;
using System.Globalization;

namespace Estrutura_Repetitiva_While
{
    class Program
    {
        static void Main(string[] args)
        {
            bool cond = true;
            while (cond == true)
            {
                Console.Write("Digite um numero: ");
                double num = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                double raizQuadrada = Math.Sqrt(num);
                if (num > 0)
                {
                    Console.WriteLine("Raiz quadrada = " + raizQuadrada.ToString("F3", CultureInfo.InvariantCulture));
                }
                else
                {
                    Console.WriteLine("Numero negativo: ");
                    cond = false;
                }
            }
        }
    }
}
