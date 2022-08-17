using System;
using System.Collections.Generic;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cria e instancia a lista vazia - é preciso incluir == (using System.Collections.Generic;)
            List<string> list = new List<string>();

            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");
            list.Insert(2, "Paulo");

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine();
            Console.WriteLine("Quantidade: " + list.Count);

            //Encontrar um primeiro elemento que satisfaça um predicado[lambda]
            string s1 = list.Find(x => x[0] == 'A');//recebe como parâmetro uma função (normal ou lambda)
            Console.WriteLine("First A: " + s1);

            /*static bool Teste(string s)
            {
                return s[0] == 'A';
            }*/

            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last A: " + s2);


            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First Position 'A': " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last Position 'A': " + pos2);

            Console.WriteLine();

            List<string> list2 = list.FindAll(x => x.Length == 5);
            foreach (string obj in list2)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine();
            list.Remove("Alex");//se não encontrar o objeto, ele simplesmente não remove
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine();
            list.RemoveAll(x => x[0] == 'M');

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine();
            list.RemoveAt(1);
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine();
            list.Add("Alan");
            list.Add("Luana");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine();
            list.RemoveRange(0, 2);
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }


        }
    }
}


/* 
            List<string> list2 = new List<string> { "Maria", "Alex", };
 */
