using OnlineStore.Domain.Orders;
using OnlineStore.Domain.ShoppingCarts;
using System;
using System.Collections.Generic;

namespace CommandRe.Domain.Products
{
    public partial class Product
    {
        public Product()
        {
            ProductCategory = new HashSet<ProductCategory>();
            ProductCategoryfeaturegroup = new HashSet<ProductCategoryfeaturegroup>();
            ProductProductdescription = new HashSet<ProductProductdescription>();
            ProductProductfeature = new HashSet<ProductProductfeature>();
            ProductProductrelated = new HashSet<ProductProductrelated>();
        }

        public long ProductId { get; set; }
        public string HighPic { get; set; }
        public string Name { get; set; }
        public string Quality { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public string Title { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? SupplierId { get; set; }

        public virtual ICollection<ProductCategory> ProductCategory { get; set; }
        public virtual ICollection<ProductCategoryfeaturegroup> ProductCategoryfeaturegroup { get; set; }
        public virtual ICollection<ProductProductdescription> ProductProductdescription { get; set; }
        public virtual ICollection<ProductProductfeature> ProductProductfeature { get; set; }
        public virtual ICollection<ProductProductrelated> ProductProductrelated { get; set; }
        public virtual ICollection<ShoppingCartItem> ShoppingCarts { get; set; }
        public virtual ICollection<OrderItem> Orders { get; set; }
        public virtual Supplier Supplier { get; set; }
    }
}
