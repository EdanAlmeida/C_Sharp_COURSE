using System;

namespace Operadores_Comparativos_Logicos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Operadores Comparativos
            int a = 10;
            bool c1 = a < 10;
            Console.WriteLine(c1);

            bool c2 = a < 20;
            Console.WriteLine(c2);

            bool c3 = a != 9;
            Console.WriteLine(c3);

            Console.WriteLine("=============================================");
            //Operadores Lógicos
            //&& -> and     || -> or        ! -> not
            //precedencia: ! > && > ||
            bool c4 = !(2 > 3) && 4 != 5;
            Console.WriteLine(c4);

            Console.WriteLine("=============================================");
            bool c5 = 2 > 3 || 4 != 5; //true
            bool c6 = !(2 > 3) && 4 != 5; //true
            bool c7 = 10 < 5; //false
            bool c8 = c5 || c6 && c7; //true

            Console.WriteLine(c8);
        }
    }
}
