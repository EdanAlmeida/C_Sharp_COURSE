using System;

namespace Exercicios_While
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problema Posto de Gasolina
            Console.WriteLine("============ BR MANIA ============");
            Console.WriteLine("| CODIGO                 PRODUTO |");
            Console.WriteLine("| ------------------------------ |");
            Console.WriteLine("|   1                    Alcool  |");
            Console.WriteLine("|   2                   Gasolina |");
            Console.WriteLine("|   3                    Diesel  |");
            Console.WriteLine("|                                |");
            Console.WriteLine("|   4                     Sair   |");
            Console.WriteLine("|================================|");
            Console.WriteLine("|========= VOLTE SEMPRE! ========|");
            Console.WriteLine("|================================|");

            bool check = true;
            int somaAlcool = 0, somaGas = 0, somaDiesel = 0;

            while (check == true)
            {
                Console.WriteLine("Qual combustível você mais usa? ");
                int pref = int.Parse(Console.ReadLine());
                if (pref == 1)
                {
                    somaAlcool += 1;
                }
                else if (pref == 2)
                {
                    somaGas += 1;
                }
                else if (pref == 3)
                {
                    somaDiesel += 1;
                }
                else if (pref == 4)
                {
                    check = false;
                }
                else
                {
                    Console.WriteLine("Opação inválida! ");
                }
            }
            Console.WriteLine("MUITO OBRIGADO!");
            Console.WriteLine("Alcool = " + somaAlcool);
            Console.WriteLine("Gasolina = " + somaGas);
            Console.WriteLine("Diesel = " + somaDiesel);

        }
    }
}


/*// Problema Senha
            int senha = 2002;
            bool check = true;

            while (check == true)
            {
                Console.Write("Digite sua senha para entrar: ");
                int userInput = int.Parse(Console.ReadLine());
                if (userInput != senha)
                {
                    Console.WriteLine("Senha Invalida! ");
                }
                else
                {
                    Console.WriteLine("Acesso Permitido! ");
                    check = false;
                }
            }*/


/*
 ///Problema Plano Cartesiano
            bool check = true;

            while(check == true)
            {
                Console.WriteLine("Digite o valor de 'X': ");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o valor de 'Y': ");
                int y = int.Parse(Console.ReadLine());

                if(x == 0 || y == 0)
                {
                    check = false;
                }
                else if(x > 0 && y > 0)
                {
                    Console.WriteLine("QUADRANTE 1");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("QUADRANTE 2");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("QUADRANTE 3");
                }
                else
                {
                    Console.WriteLine("QUADRANTE 4");
                }

            }


 */
