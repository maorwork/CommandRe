using System;
using System.Collections.Generic;

namespace CommandRe.Domain.Products
{
    public partial class Category
    {
        public Category()
        {
            CategoryName = new HashSet<CategoryName>();
            ProductCategory = new HashSet<ProductCategory>();
        }

        public long CategoryId { get; set; }

        public virtual ICollection<CategoryName> CategoryName { get; set; }
        public virtual ICollection<ProductCategory> ProductCategory { get; set; }
    }
}
