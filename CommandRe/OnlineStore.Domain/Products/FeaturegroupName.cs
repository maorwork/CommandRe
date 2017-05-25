using System;
using System.Collections.Generic;

namespace CommandRe.Domain.Products
{
    public partial class FeaturegroupName
    {
        public long FeatureGroupId { get; set; }
        public long NameId { get; set; }

        public virtual Featuregroup FeatureGroup { get; set; }
        public virtual Name Name { get; set; }
    }
}
