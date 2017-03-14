using System.Collections.Generic;

namespace CommandRe.Domain.Products
{
    public class Product
    {
        public Product()
        {
            ShoppingCarts = new HashSet<OnlineStore.Domain.ShoppingCarts.ShoppingCartItem>();
            Orders = new HashSet<OnlineStore.Domain.Orders.OrderItem>();
            Categories = new HashSet<ProductCategory>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int BrandId { get; set; }
        public int TypeId { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public bool Active { get; set; }


        public virtual ICollection<ProductCategory> Categories { get; set; }
        public virtual ICollection<OnlineStore.Domain.ShoppingCarts.ShoppingCartItem> ShoppingCarts { get; set; }
        public virtual ICollection<OnlineStore.Domain.Orders.OrderItem> Orders { get; set; }
    }
}
