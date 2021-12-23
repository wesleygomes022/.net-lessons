using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProj.Entities.Enum;

namespace TestProj.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public Client Client { get; set; }

        public Order()
        {
            Moment = DateTime.Now;
        }
        public double Total()
        {
            double acc = 0;
            foreach (OrderItem el in Items)
            {
                acc += el.SubTotal();
            }
            return acc;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Order moment: ");
            sb.AppendLine(Moment.ToString());
            sb.Append("Order status: ");
            sb.AppendLine(Status.ToString());
            sb.Append("Client: ");
            sb.AppendLine($"{Client.Name} {Client.BirthDate.ToString("dd/MM/yyyy")} - {Client.Email}");
            sb.AppendLine("Order items: ");
            foreach(OrderItem el in Items)
            {
                sb.Append(el.Product.Name.ToString());
                sb.Append(", ");
                sb.Append("$");
                sb.Append(el.Product.Price.ToString());
                sb.Append(", ");
                sb.Append("Quantity: ");
                sb.Append(el.Quantity.ToString());
                sb.Append(", ");
                sb.Append("Subtotal: $");
                sb.AppendLine(el.SubTotal().ToString());
            }
            sb.Append("Total price: $");
            sb.AppendLine(Total().ToString());
            return sb.ToString();
        }

    }
}
