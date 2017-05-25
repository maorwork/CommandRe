using System;
using System.Collections.Generic;

namespace CommandRe.Domain.Products
{
    public partial class ProductCategory
    {
        public long ProductId { get; set; }
        public long CategoryId { get; set; }

        public virtual Category Category { get; set; }
        public virtual Product Product { get; set; }
    }
}
