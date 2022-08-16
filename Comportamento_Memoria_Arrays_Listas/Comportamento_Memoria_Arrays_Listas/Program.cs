using System;

namespace Comportamento_Memoria_Arrays_Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nullables
            //double x = null; -> errado porque é um 'struct'

            //jeito certo de declarar
            Nullable<double> x = null;
            double? y = null; //jeito mais simples de fazer
            double? z = 10.0;

            Console.WriteLine(x.GetValueOrDefault()); //pega o valor atribuído ou o valor padrão (double = 0) 
            Console.WriteLine(z.GetValueOrDefault());

            Console.WriteLine(x.HasValue);
            Console.WriteLine(z.HasValue);

            if (x.HasValue)
            {
                Console.WriteLine(x.Value); //dá um erro se tentar chamar ela a partir de um objeto nulo que vale 'null'
            }
            else
            {
                Console.WriteLine("X is null");
            }
            
            if (z.HasValue)
            {
                Console.WriteLine(z.Value);
            }
            else
            {
                Console.WriteLine("Z is null");
            }


            double? a = null;
            double? b = 10.0;

            double c = a ?? 5;
            double d = b ?? 5;

            Console.WriteLine(c);
            Console.WriteLine(d);
            
        }
    }
}


/*
            //cria apenas um valor na memória stack (caixa) <> de uma referência na memória heap (ponteiramento)
            Point p;
            p.X = 10;
            p.Y = 20;

            Console.WriteLine(p);

            //recria com valores '0';
            p = new Point();
 */
