using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommandRe.Domain.Products
{
    public class ProductCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public bool Active { get; set; }
    }
}
