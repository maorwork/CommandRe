using CommandRe.Domain.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineStore.Domain.ShoppingCarts
{
    public class ShoppingCartItem
    {
        public int ShoppingCartId { get; set; }

        public virtual ShoppingCart ShoppingCart { get; set; }

        public int Quantity { get; set; }

        public long ProductId { get; set; }

        public virtual Product Product { get; set; }
    }
}
