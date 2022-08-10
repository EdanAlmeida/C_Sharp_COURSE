using System;

namespace Estrutura_Condicional
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a hora atual? ");
            int hora = int.Parse(Console.ReadLine());

            if (hora > 0 && hora < 12)
            {
                Console.WriteLine("Bom dia!");
            }
            else if (hora >= 12 && hora < 18)
            {
                Console.WriteLine("Boa tarde!");
            }
            else if(hora >= 18 && hora <= 23)
            {
                Console.WriteLine("Boa noite");
            }
            else
            {
                Console.WriteLine("Hora Invalida!");
            }

        }
    }
}

/*
             ///Simples
            int x = 10;
            
            Console.WriteLine("Bom dia!");
            if (x > 5)
            {
                Console.WriteLine("Boa tarde!");
            }
            Console.WriteLine("Boa noite!");
 */



/*
             //Composta
            Console.WriteLine("Entre com um numero inteiro: ");
            int x = int.Parse(Console.ReadLine());

            if(x % 2 == 0)
            {
                Console.WriteLine("PAR!");
            }
            else
            {
                Console.WriteLine("IMPAR");
            }
 */
