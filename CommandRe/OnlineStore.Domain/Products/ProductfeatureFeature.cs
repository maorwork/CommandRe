using System;
using System.Collections.Generic;

namespace CommandRe.Domain.Products
{
    public partial class ProductfeatureFeature
    {
        public long ProductFeatureId { get; set; }
        public long FeatureId { get; set; }

        public virtual Feature Feature { get; set; }
        public virtual Productfeature ProductFeature { get; set; }
    }
}
