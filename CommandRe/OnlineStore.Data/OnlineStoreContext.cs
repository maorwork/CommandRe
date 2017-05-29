using CommandRe.Domain.Products;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using OnlineStore.Data.EntityConfigurations;
using OnlineStore.Domain.Orders;
using OnlineStore.Domain.ShoppingCarts;
using OnlineStore.Domain.Users;
using System;

namespace OnlineStore.Data
{
    public class OnlineStoreContext : IdentityDbContext<User, UserRole, int>
    {
        public DbSet<UserAddress> UserAddress { get; set; }

        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<CategoryName> CategoryName { get; set; }
        public virtual DbSet<Categoryfeaturegroup> Categoryfeaturegroup { get; set; }
        public virtual DbSet<CategoryfeaturegroupFeaturegroup> CategoryfeaturegroupFeaturegroup { get; set; }

        public virtual DbSet<Feature> Feature { get; set; }
        public virtual DbSet<FeatureName> FeatureName { get; set; }
        public virtual DbSet<Featuregroup> Featuregroup { get; set; }
        public virtual DbSet<FeaturegroupName> FeaturegroupName { get; set; }

        public virtual DbSet<Name> Name { get; set; }

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductCategory> ProductCategory { get; set; }
        public virtual DbSet<ProductCategoryfeaturegroup> ProductCategoryfeaturegroup { get; set; }
        public virtual DbSet<ProductProductdescription> ProductProductdescription { get; set; }
        public virtual DbSet<ProductProductfeature> ProductProductfeature { get; set; }
        public virtual DbSet<ProductProductrelated> ProductProductrelated { get; set; }
        public virtual DbSet<Productdescription> Productdescription { get; set; }
        public virtual DbSet<Productfeature> Productfeature { get; set; }
        public virtual DbSet<ProductfeatureFeature> ProductfeatureFeature { get; set; }
        public virtual DbSet<Productrelated> Productrelated { get; set; }

        public virtual DbSet<Supplier> Supplier { get; set; }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<OrderStatus> OrderStatus { get; set; }

        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }


        public OnlineStoreContext(DbContextOptions<OnlineStoreContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            base.OnModelCreating(builder);

            builder.HasDefaultSchema("ApplicationData");

            builder.Entity<UserRole>().ConfigureUserRole();

            builder.Entity<IdentityUserRole<int>>().ConfigureIdentityUserRole();

            builder.Entity<IdentityUserLogin<int>>().ConfigureIdentityUserLogin();

            builder.Entity<IdentityUserToken<int>>().ConfigureIdentityUserToken();

            builder.Entity<IdentityUserClaim<int>>().ConfigureIdentityUserClaim();

            builder.Entity<IdentityRoleClaim<int>>().ConfigureIdentityRoleClaim();


            builder.Entity<User>().ConfigureUser();

            builder.Entity<UserAddress>().ConfigureUserAddress();


            builder.Entity<Product>().ConfigureProduct();

            builder.Entity<Category>(entity =>
            {
                entity.ToTable("category", "Product");

                entity.Property(e => e.CategoryId)
                    .HasColumnName("category_id")
                    .ValueGeneratedNever();
            });

            builder.Entity<CategoryName>(entity =>
            {
                entity.HasKey(e => new { e.CategoryId, e.NameId })
                    .HasName("PK_category_name_category_id");

                entity.ToTable("category_name", "Product");

                entity.HasIndex(e => e.CategoryId);

                entity.HasIndex(e => e.NameId);

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.NameId).HasColumnName("name_id");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.CategoryName)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.Name)
                    .WithMany(p => p.CategoryName)
                    .HasForeignKey(d => d.NameId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            builder.Entity<Categoryfeaturegroup>(entity =>
            {
                entity.ToTable("categoryfeaturegroup", "Product");

                entity.Property(e => e.CategoryFeatureGroupId)
                    .HasColumnName("categoryFeatureGroup_id")
                    .ValueGeneratedNever();
            });

            builder.Entity<CategoryfeaturegroupFeaturegroup>(entity =>
            {
                entity.HasKey(e => new { e.CategoryFeatureGroupId, e.FeatureGroupId })
                    .HasName("PK_categoryfeaturegroup_featuregroup_categoryFeatureGroup_id");

                entity.ToTable("categoryfeaturegroup_featuregroup", "Product");

                entity.HasIndex(e => e.CategoryFeatureGroupId);

                entity.HasIndex(e => e.FeatureGroupId);

                entity.Property(e => e.CategoryFeatureGroupId).HasColumnName("categoryFeatureGroup_id");

                entity.Property(e => e.FeatureGroupId).HasColumnName("featureGroup_id");

                entity.HasOne(d => d.CategoryFeatureGroup)
                    .WithMany(p => p.CategoryfeaturegroupFeaturegroup)
                    .HasForeignKey(d => d.CategoryFeatureGroupId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.FeatureGroup)
                    .WithMany(p => p.CategoryfeaturegroupFeaturegroup)
                    .HasForeignKey(d => d.FeatureGroupId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            builder.Entity<Feature>(entity =>
            {
                entity.ToTable("feature", "Product");

                entity.Property(e => e.FeatureId)
                    .HasColumnName("feature_id")
                    .ValueGeneratedNever();
            });

            builder.Entity<FeatureName>(entity =>
            {
                entity.HasKey(e => new { e.FeatureId, e.NameId })
                    .HasName("PK_feature_name_feature_id");

                entity.ToTable("feature_name", "Product");

                entity.HasIndex(e => e.FeatureId);

                entity.HasIndex(e => e.NameId);

                entity.Property(e => e.FeatureId).HasColumnName("feature_id");

                entity.Property(e => e.NameId).HasColumnName("name_id");

                entity.HasOne(d => d.Feature)
                    .WithMany(p => p.FeatureName)
                    .HasForeignKey(d => d.FeatureId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.Name)
                    .WithMany(p => p.FeatureName)
                    .HasForeignKey(d => d.NameId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            builder.Entity<Featuregroup>(entity =>
            {
                entity.ToTable("featuregroup", "Product");

                entity.Property(e => e.FeatureGroupId)
                    .HasColumnName("featureGroup_id")
                    .ValueGeneratedNever();
            });

            builder.Entity<FeaturegroupName>(entity =>
            {
                entity.HasKey(e => new { e.FeatureGroupId, e.NameId })
                    .HasName("PK_featuregroup_name_featureGroup_id");

                entity.ToTable("featuregroup_name", "Product");

                entity.HasIndex(e => e.FeatureGroupId);

                entity.HasIndex(e => e.NameId);

                entity.Property(e => e.FeatureGroupId).HasColumnName("featureGroup_id");

                entity.Property(e => e.NameId).HasColumnName("name_id");

                entity.HasOne(d => d.FeatureGroup)
                    .WithMany(p => p.FeaturegroupName)
                    .HasForeignKey(d => d.FeatureGroupId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.Name)
                    .WithMany(p => p.FeaturegroupName)
                    .HasForeignKey(d => d.NameId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            builder.Entity<Name>(entity =>
            {
                entity.ToTable("name", "Product");

                entity.Property(e => e.NameId)
                    .HasColumnName("name_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Value).HasColumnName("value");
            });

            builder.Entity<Product>(entity =>
            {
                entity.ToTable("product", "Product");

                entity.HasIndex(e => e.SupplierId);

                entity.Property(e => e.ProductId)
                    .HasColumnName("product_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.HighPic)
                    .HasColumnName("highPic")
                    .HasMaxLength(255);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.Quality)
                    .HasColumnName("quality")
                    .HasMaxLength(255);

                entity.Property(e => e.ReleaseDate)
                    .HasColumnName("releaseDate")
                    .HasColumnType("date");

                entity.Property(e => e.SupplierId).HasColumnName("supplier_id");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(255);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("updateDate")
                    .HasColumnType("date");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.SupplierId);
            });

            builder.Entity<ProductCategory>(entity =>
            {
                entity.HasKey(e => new { e.ProductId, e.CategoryId })
                    .HasName("PK_product_category_product_id");

                entity.ToTable("product_category", "Product");

                entity.HasIndex(e => e.CategoryId);

                entity.HasIndex(e => e.ProductId);

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.ProductCategory)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductCategory)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            builder.Entity<ProductCategoryfeaturegroup>(entity =>
            {
                entity.HasKey(e => new { e.ProductId, e.CategoryFeatureGroupId })
                    .HasName("PK_product_categoryfeaturegroup_product_id");

                entity.ToTable("product_categoryfeaturegroup", "Product");

                entity.HasIndex(e => e.CategoryFeatureGroupId);

                entity.HasIndex(e => e.ProductId);

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.CategoryFeatureGroupId).HasColumnName("categoryFeatureGroup_id");

                entity.HasOne(d => d.CategoryFeatureGroup)
                    .WithMany(p => p.ProductCategoryfeaturegroup)
                    .HasForeignKey(d => d.CategoryFeatureGroupId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductCategoryfeaturegroup)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            builder.Entity<ProductProductdescription>(entity =>
            {
                entity.HasKey(e => new { e.ProductId, e.DescriptionId })
                    .HasName("PK_product_productdescription_product_id");

                entity.ToTable("product_productdescription", "Product");

                entity.HasIndex(e => e.DescriptionId);

                entity.HasIndex(e => e.ProductId);

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.DescriptionId).HasColumnName("description_id");

                entity.HasOne(d => d.Description)
                    .WithMany(p => p.ProductProductdescription)
                    .HasForeignKey(d => d.DescriptionId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductProductdescription)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            builder.Entity<ProductProductfeature>(entity =>
            {
                entity.HasKey(e => new { e.ProductId, e.ProductFeatureId })
                    .HasName("PK_product_productfeature_product_id");

                entity.ToTable("product_productfeature", "Product");

                entity.HasIndex(e => e.ProductFeatureId);

                entity.HasIndex(e => e.ProductId);

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.ProductFeatureId).HasColumnName("productFeature_id");

                entity.HasOne(d => d.ProductFeature)
                    .WithMany(p => p.ProductProductfeature)
                    .HasForeignKey(d => d.ProductFeatureId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductProductfeature)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            builder.Entity<ProductProductrelated>(entity =>
            {
                entity.HasKey(e => new { e.ProductId, e.ProductRelatedId })
                    .HasName("PK_product_productrelated_product_id");

                entity.ToTable("product_productrelated", "Product");

                entity.HasIndex(e => e.ProductId);

                entity.HasIndex(e => e.ProductRelatedId);

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.ProductRelatedId).HasColumnName("productRelated_id");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductProductrelated)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.ProductRelated)
                    .WithMany(p => p.ProductProductrelated)
                    .HasForeignKey(d => d.ProductRelatedId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            builder.Entity<Productdescription>(entity =>
            {
                entity.HasKey(e => e.DescriptionId)
                    .HasName("PK_productdescription_description_id");

                entity.ToTable("productdescription", "Product");

                entity.Property(e => e.DescriptionId)
                    .HasColumnName("description_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.LongDescription).HasColumnName("longDescription");

                entity.Property(e => e.PdfUrl)
                    .HasColumnName("pdfUrl")
                    .HasMaxLength(255);

                entity.Property(e => e.ShortDescription).HasColumnName("shortDescription");

                entity.Property(e => e.Url)
                    .HasColumnName("url")
                    .HasMaxLength(255);
            });

            builder.Entity<Productfeature>(entity =>
            {
                entity.ToTable("productfeature", "Product");

                entity.Property(e => e.ProductFeatureId)
                    .HasColumnName("productFeature_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.PresentationValue).HasColumnName("presentationValue");
            });

            builder.Entity<ProductfeatureFeature>(entity =>
            {
                entity.HasKey(e => new { e.ProductFeatureId, e.FeatureId })
                    .HasName("PK_productfeature_feature_productFeature_id");

                entity.ToTable("productfeature_feature", "Product");

                entity.HasIndex(e => e.FeatureId);

                entity.HasIndex(e => e.ProductFeatureId);

                entity.Property(e => e.ProductFeatureId).HasColumnName("productFeature_id");

                entity.Property(e => e.FeatureId).HasColumnName("feature_id");

                entity.HasOne(d => d.Feature)
                    .WithMany(p => p.ProductfeatureFeature)
                    .HasForeignKey(d => d.FeatureId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.ProductFeature)
                    .WithMany(p => p.ProductfeatureFeature)
                    .HasForeignKey(d => d.ProductFeatureId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            builder.Entity<Productrelated>(entity =>
            {
                entity.ToTable("productrelated", "Product");

                entity.Property(e => e.ProductRelatedId)
                    .HasColumnName("productRelated_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ProductAffiliatedId).HasColumnName("productAffiliatedId");
            });

            builder.Entity<Supplier>(entity =>
            {
                entity.ToTable("supplier", "Product");

                entity.Property(e => e.SupplierId)
                    .HasColumnName("supplier_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);
            });

            builder.Entity<Order>().ConfigureOrder();

            builder.Entity<OrderItem>().ConfigureOrdersItem();

            builder.Entity<OrderStatus>().ConfigureOrderStatus();


            builder.Entity<ShoppingCart>().ConfigureShoppingCart();

            builder.Entity<ShoppingCartItem>().ConfigureShoppingCartItem();

        }
    }
}
