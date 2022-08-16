using System;

namespace Modificador_Params
{
    class Program
    {
        static void Main(string[] args)
        {
            //Solução usando o modificador de parâmetros Params
            int result = Calculator.Sum(2, 3, 4);
            Console.WriteLine(result);
        }
    }
}


/*
            //Solução ruim para somar
            int s1 = Calculator.Sum(2, 3);
            int s2 = Calculator.Sum(2, 3, 4);

            Console.WriteLine(s1);
            Console.WriteLine(s2);
 */


/*
 //Solução usando vetor
            int result = Calculator.Sum(new int[] { 10, 20, 30, 40 });
            Console.WriteLine(result);
 */
