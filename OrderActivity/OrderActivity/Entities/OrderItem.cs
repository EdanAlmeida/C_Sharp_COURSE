using System;
using System.Globalization;

namespace OrderActivity.Entities
{
    class OrderItem
        //Classe da entidade orderitem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem()
            //construtor padrão
        {
        }

        public OrderItem(int quantity, double price, Product product)
            //construtor com argumentos
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        public double Subtotal()
            //método para obter o subtotal (quantidade * preço)
        {
            return Quantity * Price;
        }

        public override string ToString()
            //método de output (override)
        {
            return Product.Name
                + ", $"
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + ", Quantity: "
                + Quantity
                + ", Subtotal: $"
                + Subtotal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
