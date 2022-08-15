using System;
using System.Globalization;

/*
 Ordem sugerida de Organização:
    - Atributos privados;
    - Propriedades autoimplementadas
    - Construtores
    - Propriedades customizadas
    - Outros métodos de classe
 */

namespace Course
{
    class Produto
    {
        //Usando Auto Property
        private string _nome; //possui uma lógica particular; assim, não pode ser utilizado auto property
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        
        public Produto()
        {
        }

        
        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;

        }


        public string Nome
        {
            get { return _nome; }
            set {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }


        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return _nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}


/*
 using System;
using System.Globalization;

namespace Course
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;


        //Para aceitar o construtor padrão
        public Produto()
        {

        }

        
        //Construtor para receber os parâmetros
        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }


        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = 5; //Por padrão, se deixar essa linha em branco, ela irá preencher com o valor '0'
        }


        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return Nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
 */



/*
 using System;
using System.Globalization;

namespace Course
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;


        //Iniciar somente a quantidade para usar a palavra 'this'
        public Produto()
        {
            Quantidade = 10;
        }

        
        //Construtor reaproveitando o construtor anterior
        public Produto(string nome, double preco) : this()
        {
            Nome = nome;
            Preco = preco;
        }


        public Produto(string nome, double preco, int quantidade) : this(nome, preco )
        {
            Quantidade = quantidade; 
        }


        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return Nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
 */



/*
    //encapsulamento manual <> sem properties
    class Produto
    {
        //mudando os atributos de 'public' para 'private', protegemos o acesso e alteração
        //muda o padrão de nomes
        private string _nome;
        private double _preco;
        private int _quantidade;


        
        public Produto()
        {
        }

        
        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;

        }


        public string GetNome()
        {
            return _nome;
        }


        public void SetNome(string nome)
        {
            if (nome != null && nome.Length > 1)
            {
                _nome = nome;
            }
            else
            {
                Console.WriteLine("Sai fora, Zé Mané!");
            }
        }


        public double GetPreco()
        {
            return _preco;
        }


        public int GetQuantidade()
        {
            return _quantidade;
        }


        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }
        public override string ToString()
        {
            return _nome
            + ", $ "
            + _preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + _quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
 */


/*
 //mudando os atributos de 'public' para 'private', protegemos o acesso e alteração
        //muda o padrão de nomes
        private string _nome;
        private double _preco;
        private int _quantidade;


        
        public Produto()
        {
        }

        
        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;

        }


        public string Nome
        {
            get { return _nome; }
            set {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }


        public double Preco
        {
            get { return _preco; }
        }


        public int Quantidade
        {
            get { return _quantidade; }
        }


        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }
        public override string ToString()
        {
            return _nome
            + ", $ "
            + _preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + _quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
 
 */