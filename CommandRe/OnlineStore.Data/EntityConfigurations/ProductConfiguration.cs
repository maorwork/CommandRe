using CommandRe.Domain.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace OnlineStore.Data.EntityConfigurations
{
    public static class ProductConfiguration
    {
        public static void ConfigureProduct(this EntityTypeBuilder<Product> b)
        {
            b.ToTable("Products","Product");

            b.HasKey(o => o.ProductId);
        }
    }
}
