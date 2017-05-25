using System;
using System.Collections.Generic;

namespace CommandRe.Domain.Products
{
    public partial class Feature
    {
        public Feature()
        {
            FeatureName = new HashSet<FeatureName>();
            ProductfeatureFeature = new HashSet<ProductfeatureFeature>();
        }

        public long FeatureId { get; set; }

        public virtual ICollection<FeatureName> FeatureName { get; set; }
        public virtual ICollection<ProductfeatureFeature> ProductfeatureFeature { get; set; }
    }
}
