using System;
using System.Collections.Generic;

namespace CommandRe.Domain.Products
{
    public partial class Productdescription
    {
        public Productdescription()
        {
            ProductProductdescription = new HashSet<ProductProductdescription>();
        }

        public long DescriptionId { get; set; }
        public string LongDescription { get; set; }
        public string PdfUrl { get; set; }
        public string ShortDescription { get; set; }
        public string Url { get; set; }

        public virtual ICollection<ProductProductdescription> ProductProductdescription { get; set; }
    }
}
