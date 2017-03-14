﻿using OnlineStore.Domain.Users;
using System;
using System.Collections.Generic;

namespace OnlineStore.Domain.Orders
{
    public class Order
    {
        public Order()
        {
            Products = new HashSet<OrderItem>();
        }
        public int Id { get; set; }
        public int UserId { get; set; }
        public double TotalPrice { get; set; }
        public DateTime OrderedDate { get; set; }
        public DateTime ShippedDate { get; set; }
        public int ShippingAddressId { get; set; }
        public virtual UserAddress ShippingAddress { get; set; }
        public int StatusId { get; set; }
        public virtual OrderStatus Status { get; set; }
        public virtual ICollection<OrderItem> Products { get; set; }
    }
}
