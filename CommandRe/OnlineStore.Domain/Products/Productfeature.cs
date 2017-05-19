using System;
using System.Collections.Generic;

namespace OnlineStore.Data.scaffold
{
    public partial class Productfeature
    {
        public Productfeature()
        {
            ProductfeatureFeature = new HashSet<ProductfeatureFeature>();
            ProductProductfeature = new HashSet<ProductProductfeature>();
        }

        public long ProductFeatureId { get; set; }
        public string PresentationValue { get; set; }

        public virtual ICollection<ProductfeatureFeature> ProductfeatureFeature { get; set; }
        public virtual ICollection<ProductProductfeature> ProductProductfeature { get; set; }
    }
}
