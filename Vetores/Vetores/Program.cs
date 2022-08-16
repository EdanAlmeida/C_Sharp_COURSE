using System;
using System.Globalization;

namespace Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vetores tipo (referência) - refatora com o construtor na classe
            int n = int.Parse(Console.ReadLine());

            Produto[] vect = new Produto[n];

            for (int i = 0; i < n; i++)
            {
                string nome = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vect[i] = new Produto(nome, preco); //mudei o construtor para a classe
            }

            double soma = 0.0;

            for (int i = 0; i < n; i++)
            {
                soma += vect[i].Preco;
            }

            double media = soma / n;

            Console.WriteLine();
            Console.WriteLine("Preço Médio: R$ " + media.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}

/*
            //Vetores tipo (struct)
            int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n];

            for (int i = 0; i < n; i++)
            {
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double sum = 0.0;

            for (int i = 0; i < n; i++)
            {
                sum += vect[i];
            }

            double media = sum / n;

            Console.WriteLine("Altura Média = " + media.ToString("F2", CultureInfo.InvariantCulture));
 */


/*
             //Vetores tipo (referência)
            int n = int.Parse(Console.ReadLine());

            Produto[] vect = new Produto[n];

            for (int i = 0; i < n; i++)
            {
                string nome = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vect[i] = new Produto { Nome = nome, Preco = preco }; //pode criar o construtor na classe
            }

            double soma = 0.0;

            for (int i = 0; i < n; i++)
            {
                soma += vect[i].Preco;
            }

            double media = soma / n;

            Console.WriteLine();
            Console.WriteLine("Preço Médio: R$ " + media.ToString("F2", CultureInfo.InvariantCulture));
 */

