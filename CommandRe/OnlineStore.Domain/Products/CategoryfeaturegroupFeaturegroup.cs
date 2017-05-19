using System;
using System.Collections.Generic;

namespace OnlineStore.Data.scaffold
{
    public partial class CategoryfeaturegroupFeaturegroup
    {
        public long CategoryFeatureGroupId { get; set; }
        public long FeatureGroupId { get; set; }

        public virtual Categoryfeaturegroup CategoryFeatureGroup { get; set; }
        public virtual Featuregroup FeatureGroup { get; set; }
    }
}
