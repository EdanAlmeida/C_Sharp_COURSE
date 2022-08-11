using System;

namespace Functions_Syntax
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Maior de Três
            Console.WriteLine("Digite tres numeros: ");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            int resultado = Maior(n1, n2, n3);

            Console.WriteLine("Maior = " + resultado);

        }


        static int Maior(int a, int b, int c)
        {
            int m;
            if (a > b && a > c)
            {
                m = a;
            }
            else if (b > c)
            {
                m = b;
            }
            else
            {
                m = c;
            }
            return m;
        }


    }
}

/*DEBUGGING
    -> Breakpoint == F9
    -> Debugging == F5
    -> Passo a Passo == F10  [pula a função]
    -> Interromper == Shift + F5 / botão Stop
    -> Entra Função == F!! [entra na função executando passo a passo]
 */

