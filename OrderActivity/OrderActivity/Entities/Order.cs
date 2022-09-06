using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;
using OrderActivity.Entities.Enums;


namespace OrderActivity.Entities
{
    class Order
        //classe da entidade order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order()
            //construtor padrão
        {
        }

        public Order(DateTime date, OrderStatus status, Client client)
            //construtor com argumentos - lista
        {
            Moment = date;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item)
            //método para adicionar item na lista
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
            //método para remover item da lista
        {
            Items.Remove(item);
        }

        public double Total()
            //método para calcular o total do pedido
        {
            double sum = 0;
            foreach (OrderItem item in Items)
                //percorre a lista para somar o total do pedido
            {
                sum += item.Subtotal();
            }
            return sum;
        }

        public override string ToString()
            //método (stringBuilder) para output
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order Moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order Status: " + Status);
            sb.AppendLine("Client: " + Client);
            sb.AppendLine("Order Items:");
            foreach (OrderItem item in Items)
                //percorre a lista e imprime os dados
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Total Price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }

    }
}
