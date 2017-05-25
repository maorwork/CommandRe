using System;
using System.Collections.Generic;

namespace CommandRe.Domain.Products
{
    public partial class Productrelated
    {
        public Productrelated()
        {
            ProductProductrelated = new HashSet<ProductProductrelated>();
        }

        public long ProductRelatedId { get; set; }
        public long? ProductAffiliatedId { get; set; }

        public virtual ICollection<ProductProductrelated> ProductProductrelated { get; set; }
    }
}
