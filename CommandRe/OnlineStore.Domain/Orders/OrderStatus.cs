using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineStore.Domain.Orders
{
    public class OrderStatus
    {
        public OrderStatus()
        {
            Orders = new HashSet<Order>();
        }
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
