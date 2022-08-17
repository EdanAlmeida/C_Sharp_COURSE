using System;

namespace Modificadores_Ref_Out
{
    class Program
    {
        static void Main(string[] args)
        {
            //Modificador 'out'
            int a = 10;
            int triple;
            Calculator.Triple(a, out triple);
            Console.WriteLine(triple);

            string[] vect = new string[] { "Maria", "Bob", "Alex" };
            foreach (string obj in vect)
            {
                Console.WriteLine(obj);
            }

            //Nesse caso o foreach acaba sendo mais prático
            for (int i = 0; i < vect.Length; i++)
            {
                Console.WriteLine(vect[i]);
            }

        }
    }
}


/*          
            //Modificador 'ref'
            int a = 10;
            Calculator.Triple(ref a);
            Console.WriteLine(a);*/
