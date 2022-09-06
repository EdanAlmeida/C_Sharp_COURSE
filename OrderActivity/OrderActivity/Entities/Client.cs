using System;

namespace OrderActivity.Entities
{
    class Client
        //Classe da entidade Cliente
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public Client()
            //construtor padrão
        {
        }

        public Client(string name,  string email, DateTime birthDate)
            //construtor com argumentos
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }

        public override string ToString()
            //étodo para output (override)
        {
            return Name
                + ", ("
                + BirthDate.ToString("dd/MM/yyyy")
                + ") - "
                + Email;
        }
    }
}
