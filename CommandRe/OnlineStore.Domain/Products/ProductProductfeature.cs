using System;
using System.Collections.Generic;

namespace CommandRe.Domain.Products
{
    public partial class ProductProductfeature
    {
        public long ProductId { get; set; }
        public long ProductFeatureId { get; set; }

        public virtual Productfeature ProductFeature { get; set; }
        public virtual Product Product { get; set; }
    }
}
