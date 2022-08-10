using System;
using System.Globalization;

namespace Exercicios_estrutura_sequencial
{
    class Program
    {
        static void Main(string[] args)
        {
            //Salario Funcionario:
            Console.WriteLine("Digite o codigo do funcionario: ");
            int numFuncionario = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o numero dehoras trabalhadas: ");
            int horasTrabalhadas = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da hora trabalhada: ");
            double valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salario = horasTrabalhadas * valorHora;
            
            Console.WriteLine("Numero funcionario: " + numFuncionario);
            Console.WriteLine("Salario R$: " + salario.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}

//Resolução de atividades:

/*
             //Problema Soma
            Console.WriteLine("Digite um numero inteiro: ");
            int numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro numero inteiro: ");
            int numero2 = int.Parse(Console.ReadLine());

            int soma = numero1 + numero2;
            Console.WriteLine("Soma: " + soma);
 */

/*
             //Problema area circulo
            Console.WriteLine("Digite o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double pi = 3.14159;
            double area = pi * Math.Pow(raio, 2);

            Console.WriteLine("Area: " + area.ToString("F4", CultureInfo.InvariantCulture));

 */


/*
            //Diferenca do produto entre números:
            Console.WriteLine("Digite o valor de 'A'(inteiro): ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de 'B'(inteiro): ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de 'C'(inteiro): ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de 'D'(inteiro): ");
            int d = int.Parse(Console.ReadLine());

            int diferenca = a * b - c * d;
            Console.WriteLine("DIFERENCA = " + diferenca);
 */

