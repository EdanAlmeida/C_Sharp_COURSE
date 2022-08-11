using System;
using System.Globalization;

namespace exercicios_estrutura_condicional
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problema Total a Pagar
            Console.WriteLine("=====================================");
            Console.WriteLine("=============== BODEGA ==============");
            Console.WriteLine("|Codigo      Especificacao       Preco|");
            Console.WriteLine("|1          Cachorro quente    R$ 4,00|");
            Console.WriteLine("|2             X Salada        R$ 4,50|");
            Console.WriteLine("|3             X Bacon         R$ 5,00|");
            Console.WriteLine("|4          Torrada Simples    R$ 2,00|");
            Console.WriteLine("|5            Refrigerante     R$ 1,50|");
            Console.WriteLine("=====================================");

            Console.WriteLine("Informe o codigo do produto e a quantidade");
            string[] valores = Console.ReadLine().Split(' ');

            int codigo = int.Parse(valores[0]);
            int quantidade = int.Parse(valores[1]);
            double total = 0;

            if (codigo == 1)
            {
                total = quantidade * 4.0;
            }
            else if(codigo == 2)
            {
                total = quantidade * 4.5;
            }
            else if (codigo == 3)
            {
                total = quantidade * 5.0;
            }
            else if (codigo == 4)
            {
                total = quantidade * 2.0;
            }
            else if (codigo == 5)
            {
                total = quantidade * 1.5;
            }
            else
            {
                Console.WriteLine("Codigo invalido!");
            }

            Console.WriteLine("TOTAL A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}


/*
             //Problema positivo/negativo
            Console.WriteLine("Digite um numero (inteiro): ");
            int numero = int.Parse(Console.ReadLine());

            if(numero < 0)
            {
                Console.WriteLine("NEGATIVO!");
            }
            else if(numero == 0)
            {
                Console.WriteLine("NEUTRO!");
            }
            else
            {
                Console.WriteLine("POSITIVO!");
            }
 */


/*
             //Problema PAR/ÍMPAR
            Console.WriteLine("Digite um numero (inteiro)");
            int numero = int.Parse(Console.ReadLine());

            if(numero % 2 == 0)
            {
                Console.WriteLine("PAR!");
            }
            else
            {
                Console.WriteLine("IMPAR!");
            }
 */

/*
             //Problema Números Multiplos
            Console.WriteLine("Digite o valor de 'A': ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de 'B': ");
            int b = int.Parse(Console.ReadLine());
            int troca = 0;

            if(a < b)
            {
                troca = b;
                b = a;
                a = troca;
            }
            
            if(a % b == 0)
            {
                Console.WriteLine("Multiplos");
            }
            else
            {
                Console.WriteLine("Não Multiplos");
            }

 */


/*
             //Problema Horas de Jogo
            Console.WriteLine("Digite a hora inicial e hora final de jogo: ");
            string[] valores = Console.ReadLine().Split(' ');
            int horaInicial = int.Parse(valores[0]);
            int horaFinal = int.Parse(valores[1]);

            int duracao;

            if(horaInicial < horaFinal)
            {
                duracao = horaFinal - horaInicial;
            }
            else
            {
                duracao = 24 - horaInicial + horaFinal;
            }

            Console.WriteLine("O JOGO DUROU " + duracao + " HORAS!");
 */
