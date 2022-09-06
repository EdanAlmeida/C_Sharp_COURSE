using System.Globalization;

namespace OrderActivity.Entities
{
    class Product
        //classe da entidade produto
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product()
            //construtor padrão
        {
        }

        public Product(string name, double price)
            //construtor com argumentos
        {
            Name = name;
            Price = price;
        }
    }
}
