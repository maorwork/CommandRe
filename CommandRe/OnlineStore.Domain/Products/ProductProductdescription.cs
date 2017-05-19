using System;
using System.Collections.Generic;

namespace OnlineStore.Data.scaffold
{
    public partial class ProductProductdescription
    {
        public long ProductId { get; set; }
        public long DescriptionId { get; set; }

        public virtual Productdescription Description { get; set; }
        public virtual Product Product { get; set; }
    }
}
