using System;
using System.Collections.Generic;
using System.Text;

namespace Vetores
{
    class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }


        //construtor
        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

    }
}
