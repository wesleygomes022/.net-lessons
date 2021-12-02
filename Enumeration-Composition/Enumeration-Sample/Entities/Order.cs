using System;
using TestProj.Entities.Enums;

namespace TestProj.Entities
{
    class Order
    {
        public int ID { get; set; }
        public DateTime Moment { get; set; } 
        public OrderStatus Status { get; set;  }

        public override string ToString()
        {
            return "ID: " + ID +
                "; \nMoment: " + Moment +
                "; \nStatus: " + Status;
        }
    }
}
