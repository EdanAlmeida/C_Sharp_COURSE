using System;

namespace Exercicio_Vetor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problema Pensionato
            Console.Write("Quantos quartos serão alugados? ");
            int numeroHospedes = int.Parse(Console.ReadLine());
            Pensionato[] reserva = new Pensionato[10];

            for (int i = 1; i <= numeroHospedes; i++)
            {
                Console.WriteLine("Aluguel #" + i + ": ");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int numeroQuarto = int.Parse(Console.ReadLine());
                reserva[numeroQuarto] = new Pensionato(nome, email);
            }

            Console.WriteLine();
            Console.WriteLine("Quartos Ocupados: ");

            for (int i = 0; i < 10; i++)
            {
                if (reserva[i] != null)
                {
                    Console.WriteLine(i + ": " + reserva[i]);
                }
            }

            

        }
    }
}
