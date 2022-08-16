using System;

namespace Exercicio_Vetor
{
    class Pensionato
    {
        //public int NumeroQuarto { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }


        public Pensionato(/*int numero, */ string nome, string email)
        {
            //NumeroQuarto = numero;
            Nome = nome;
            Email = email;
        }

        public override string ToString()
        {
            return Nome + ", " + Email;
        }

    }
}
