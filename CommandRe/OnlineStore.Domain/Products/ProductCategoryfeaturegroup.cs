using System;
using System.Collections.Generic;

namespace OnlineStore.Data.scaffold
{
    public partial class ProductCategoryfeaturegroup
    {
        public long ProductId { get; set; }
        public long CategoryFeatureGroupId { get; set; }

        public virtual Categoryfeaturegroup CategoryFeatureGroup { get; set; }
        public virtual Product Product { get; set; }
    }
}
