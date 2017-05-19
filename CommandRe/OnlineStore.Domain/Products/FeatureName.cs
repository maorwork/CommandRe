using System;
using System.Collections.Generic;

namespace OnlineStore.Data.scaffold
{
    public partial class FeatureName
    {
        public long FeatureId { get; set; }
        public long NameId { get; set; }

        public virtual Feature Feature { get; set; }
        public virtual Name Name { get; set; }
    }
}
