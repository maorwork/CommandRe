﻿using System;
using System.Collections.Generic;

namespace OnlineStore.Data.scaffold
{
    public partial class ProductCategory
    {
        public long ProductId { get; set; }
        public long CategoryId { get; set; }

        public virtual Category Category { get; set; }
        public virtual Product Product { get; set; }
    }
}
