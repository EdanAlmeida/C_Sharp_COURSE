using System;

namespace Estrutura_Repetitiva_For
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sum 'N' values
            Console.WriteLine("How many number would you like to insert? ");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            
            for (int i = 1; i <= n; i ++)
            {
                Console.Write("Type the value #" + i + " = ");
                int value = int.Parse(Console.ReadLine());
                sum += value;
            }

            Console.WriteLine("SUM = " + sum);

        }
    }
}


/*          
           //Estrutura Repetitiva For
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("I = " + i);
            }*/

