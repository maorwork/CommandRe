using System;
using System.Collections.Generic;

namespace OnlineStore.Data.scaffold
{
    public partial class ProductProductrelated
    {
        public long ProductId { get; set; }
        public long ProductRelatedId { get; set; }

        public virtual Product Product { get; set; }
        public virtual Productrelated ProductRelated { get; set; }
    }
}
