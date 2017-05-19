using System;
using System.Collections.Generic;

namespace OnlineStore.Data.scaffold
{
    public partial class Name
    {
        public Name()
        {
            CategoryName = new HashSet<CategoryName>();
            FeaturegroupName = new HashSet<FeaturegroupName>();
            FeatureName = new HashSet<FeatureName>();
        }

        public long NameId { get; set; }
        public string Value { get; set; }

        public virtual ICollection<CategoryName> CategoryName { get; set; }
        public virtual ICollection<FeaturegroupName> FeaturegroupName { get; set; }
        public virtual ICollection<FeatureName> FeatureName { get; set; }
    }
}
