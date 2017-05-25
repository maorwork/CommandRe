using System;
using System.Collections.Generic;

namespace CommandRe.Domain.Products
{
    public partial class Featuregroup
    {
        public Featuregroup()
        {
            CategoryfeaturegroupFeaturegroup = new HashSet<CategoryfeaturegroupFeaturegroup>();
            FeaturegroupName = new HashSet<FeaturegroupName>();
        }

        public long FeatureGroupId { get; set; }

        public virtual ICollection<CategoryfeaturegroupFeaturegroup> CategoryfeaturegroupFeaturegroup { get; set; }
        public virtual ICollection<FeaturegroupName> FeaturegroupName { get; set; }
    }
}
