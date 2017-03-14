﻿using CommandRe.Domain.Products;

namespace OnlineStore.Domain.Orders
{
    public class OrderItem
    {
        public int OrderId { get; set; }

        public virtual Order Order { get; set; }

        public int Quantity { get; set; }

        public int ProductId { get; set; }

        public virtual Product Product { get; set; }

    }
}
