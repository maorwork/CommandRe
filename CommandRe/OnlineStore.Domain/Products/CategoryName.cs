using System;
using System.Collections.Generic;

namespace CommandRe.Domain.Products
{
    public partial class CategoryName
    {
        public long CategoryId { get; set; }
        public long NameId { get; set; }

        public virtual Category Category { get; set; }
        public virtual Name Name { get; set; }
    }
}
