using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace OnlineStore.Data.scaffold
{
    public partial class OnlineStoreContext : DbContext
    {
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<CategoryName> CategoryName { get; set; }
        public virtual DbSet<Categoryfeaturegroup> Categoryfeaturegroup { get; set; }
        public virtual DbSet<CategoryfeaturegroupFeaturegroup> CategoryfeaturegroupFeaturegroup { get; set; }
        public virtual DbSet<Feature> Feature { get; set; }
        public virtual DbSet<FeatureName> FeatureName { get; set; }
        public virtual DbSet<Featuregroup> Featuregroup { get; set; }
        public virtual DbSet<FeaturegroupName> FeaturegroupName { get; set; }
        public virtual DbSet<Name> Name { get; set; }
        public virtual DbSet<Product> Product { get; set; }
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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=OnlineStore;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("category", "commandre");

                entity.Property(e => e.CategoryId)
                    .HasColumnName("category_id")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<CategoryName>(entity =>
            {
                entity.HasKey(e => new { e.CategoryId, e.NameId })
                    .HasName("PK_category_name_category_id");

                entity.ToTable("category_name", "commandre");

                entity.HasIndex(e => e.CategoryId)
                    .HasName("FK43C0892C8E486213");

                entity.HasIndex(e => e.NameId)
                    .HasName("FK43C0892C7D85CF73");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.NameId).HasColumnName("name_id");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.CategoryName)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("category_name$FK43C0892C8E486213");

                entity.HasOne(d => d.Name)
                    .WithMany(p => p.CategoryName)
                    .HasForeignKey(d => d.NameId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("category_name$FK43C0892C7D85CF73");
            });

            modelBuilder.Entity<Categoryfeaturegroup>(entity =>
            {
                entity.ToTable("categoryfeaturegroup", "commandre");

                entity.Property(e => e.CategoryFeatureGroupId)
                    .HasColumnName("categoryFeatureGroup_id")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<CategoryfeaturegroupFeaturegroup>(entity =>
            {
                entity.HasKey(e => new { e.CategoryFeatureGroupId, e.FeatureGroupId })
                    .HasName("PK_categoryfeaturegroup_featuregroup_categoryFeatureGroup_id");

                entity.ToTable("categoryfeaturegroup_featuregroup", "commandre");

                entity.HasIndex(e => e.CategoryFeatureGroupId)
                    .HasName("FK5A2E45219FF117F3");

                entity.HasIndex(e => e.FeatureGroupId)
                    .HasName("FK5A2E452137125593");

                entity.Property(e => e.CategoryFeatureGroupId).HasColumnName("categoryFeatureGroup_id");

                entity.Property(e => e.FeatureGroupId).HasColumnName("featureGroup_id");

                entity.HasOne(d => d.CategoryFeatureGroup)
                    .WithMany(p => p.CategoryfeaturegroupFeaturegroup)
                    .HasForeignKey(d => d.CategoryFeatureGroupId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("categoryfeaturegroup_featuregroup$FK5A2E45219FF117F3");

                entity.HasOne(d => d.FeatureGroup)
                    .WithMany(p => p.CategoryfeaturegroupFeaturegroup)
                    .HasForeignKey(d => d.FeatureGroupId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("categoryfeaturegroup_featuregroup$FK5A2E452137125593");
            });

            modelBuilder.Entity<Feature>(entity =>
            {
                entity.ToTable("feature", "commandre");

                entity.Property(e => e.FeatureId)
                    .HasColumnName("feature_id")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<FeatureName>(entity =>
            {
                entity.HasKey(e => new { e.FeatureId, e.NameId })
                    .HasName("PK_feature_name_feature_id");

                entity.ToTable("feature_name", "commandre");

                entity.HasIndex(e => e.FeatureId)
                    .HasName("FK51CCEA74A56A05C1");

                entity.HasIndex(e => e.NameId)
                    .HasName("FK51CCEA747D85CF73");

                entity.Property(e => e.FeatureId).HasColumnName("feature_id");

                entity.Property(e => e.NameId).HasColumnName("name_id");

                entity.HasOne(d => d.Feature)
                    .WithMany(p => p.FeatureName)
                    .HasForeignKey(d => d.FeatureId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("feature_name$FK51CCEA74A56A05C1");

                entity.HasOne(d => d.Name)
                    .WithMany(p => p.FeatureName)
                    .HasForeignKey(d => d.NameId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("feature_name$FK51CCEA747D85CF73");
            });

            modelBuilder.Entity<Featuregroup>(entity =>
            {
                entity.ToTable("featuregroup", "commandre");

                entity.Property(e => e.FeatureGroupId)
                    .HasColumnName("featureGroup_id")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<FeaturegroupName>(entity =>
            {
                entity.HasKey(e => new { e.FeatureGroupId, e.NameId })
                    .HasName("PK_featuregroup_name_featureGroup_id");

                entity.ToTable("featuregroup_name", "commandre");

                entity.HasIndex(e => e.FeatureGroupId)
                    .HasName("FK620BC3E137125593");

                entity.HasIndex(e => e.NameId)
                    .HasName("FK620BC3E17D85CF73");

                entity.Property(e => e.FeatureGroupId).HasColumnName("featureGroup_id");

                entity.Property(e => e.NameId).HasColumnName("name_id");

                entity.HasOne(d => d.FeatureGroup)
                    .WithMany(p => p.FeaturegroupName)
                    .HasForeignKey(d => d.FeatureGroupId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("featuregroup_name$FK620BC3E137125593");

                entity.HasOne(d => d.Name)
                    .WithMany(p => p.FeaturegroupName)
                    .HasForeignKey(d => d.NameId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("featuregroup_name$FK620BC3E17D85CF73");
            });

            modelBuilder.Entity<Name>(entity =>
            {
                entity.ToTable("name", "commandre");

                entity.Property(e => e.NameId)
                    .HasColumnName("name_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("product", "commandre");

                entity.HasIndex(e => e.SupplierId)
                    .HasName("FK50C664CFAF4C8753");

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
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("product$FK50C664CFAF4C8753");
            });

            modelBuilder.Entity<ProductCategory>(entity =>
            {
                entity.HasKey(e => new { e.ProductId, e.CategoryId })
                    .HasName("PK_product_category_product_id");

                entity.ToTable("product_category", "commandre");

                entity.HasIndex(e => e.CategoryId)
                    .HasName("FK71CEE68E8E486213");

                entity.HasIndex(e => e.ProductId)
                    .HasName("FK71CEE68E3ECD9721");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.ProductCategory)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("product_category$FK71CEE68E8E486213");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductCategory)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("product_category$FK71CEE68E3ECD9721");
            });

            modelBuilder.Entity<ProductCategoryfeaturegroup>(entity =>
            {
                entity.HasKey(e => new { e.ProductId, e.CategoryFeatureGroupId })
                    .HasName("PK_product_categoryfeaturegroup_product_id");

                entity.ToTable("product_categoryfeaturegroup", "commandre");

                entity.HasIndex(e => e.CategoryFeatureGroupId)
                    .HasName("FK81DECAD79FF117F3");

                entity.HasIndex(e => e.ProductId)
                    .HasName("FK81DECAD73ECD9721");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.CategoryFeatureGroupId).HasColumnName("categoryFeatureGroup_id");

                entity.HasOne(d => d.CategoryFeatureGroup)
                    .WithMany(p => p.ProductCategoryfeaturegroup)
                    .HasForeignKey(d => d.CategoryFeatureGroupId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("product_categoryfeaturegroup$FK81DECAD79FF117F3");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductCategoryfeaturegroup)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("product_categoryfeaturegroup$FK81DECAD73ECD9721");
            });

            modelBuilder.Entity<ProductProductdescription>(entity =>
            {
                entity.HasKey(e => new { e.ProductId, e.DescriptionId })
                    .HasName("PK_product_productdescription_product_id");

                entity.ToTable("product_productdescription", "commandre");

                entity.HasIndex(e => e.DescriptionId)
                    .HasName("FK84A4B91D8000E481");

                entity.HasIndex(e => e.ProductId)
                    .HasName("FK84A4B91D3ECD9721");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.DescriptionId).HasColumnName("description_id");

                entity.HasOne(d => d.Description)
                    .WithMany(p => p.ProductProductdescription)
                    .HasForeignKey(d => d.DescriptionId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("product_productdescription$FK84A4B91D8000E481");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductProductdescription)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("product_productdescription$FK84A4B91D3ECD9721");
            });

            modelBuilder.Entity<ProductProductfeature>(entity =>
            {
                entity.HasKey(e => new { e.ProductId, e.ProductFeatureId })
                    .HasName("PK_product_productfeature_product_id");

                entity.ToTable("product_productfeature", "commandre");

                entity.HasIndex(e => e.ProductFeatureId)
                    .HasName("FK847368973AA8E693");

                entity.HasIndex(e => e.ProductId)
                    .HasName("FK847368973ECD9721");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.ProductFeatureId).HasColumnName("productFeature_id");

                entity.HasOne(d => d.ProductFeature)
                    .WithMany(p => p.ProductProductfeature)
                    .HasForeignKey(d => d.ProductFeatureId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("product_productfeature$FK847368973AA8E693");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductProductfeature)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("product_productfeature$FK847368973ECD9721");
            });

            modelBuilder.Entity<ProductProductrelated>(entity =>
            {
                entity.HasKey(e => new { e.ProductId, e.ProductRelatedId })
                    .HasName("PK_product_productrelated_product_id");

                entity.ToTable("product_productrelated", "commandre");

                entity.HasIndex(e => e.ProductId)
                    .HasName("FKFFD089CC3ECD9721");

                entity.HasIndex(e => e.ProductRelatedId)
                    .HasName("FKFFD089CCB0A15E73");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.ProductRelatedId).HasColumnName("productRelated_id");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductProductrelated)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("product_productrelated$FKFFD089CC3ECD9721");

                entity.HasOne(d => d.ProductRelated)
                    .WithMany(p => p.ProductProductrelated)
                    .HasForeignKey(d => d.ProductRelatedId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("product_productrelated$FKFFD089CCB0A15E73");
            });

            modelBuilder.Entity<Productdescription>(entity =>
            {
                entity.HasKey(e => e.DescriptionId)
                    .HasName("PK_productdescription_description_id");

                entity.ToTable("productdescription", "commandre");

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

            modelBuilder.Entity<Productfeature>(entity =>
            {
                entity.ToTable("productfeature", "commandre");

                entity.Property(e => e.ProductFeatureId)
                    .HasColumnName("productFeature_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.PresentationValue).HasColumnName("presentationValue");
            });

            modelBuilder.Entity<ProductfeatureFeature>(entity =>
            {
                entity.HasKey(e => new { e.ProductFeatureId, e.FeatureId })
                    .HasName("PK_productfeature_feature_productFeature_id");

                entity.ToTable("productfeature_feature", "commandre");

                entity.HasIndex(e => e.FeatureId)
                    .HasName("FK3E6019BEA56A05C1");

                entity.HasIndex(e => e.ProductFeatureId)
                    .HasName("FK3E6019BE3AA8E693");

                entity.Property(e => e.ProductFeatureId).HasColumnName("productFeature_id");

                entity.Property(e => e.FeatureId).HasColumnName("feature_id");

                entity.HasOne(d => d.Feature)
                    .WithMany(p => p.ProductfeatureFeature)
                    .HasForeignKey(d => d.FeatureId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("productfeature_feature$FK3E6019BEA56A05C1");

                entity.HasOne(d => d.ProductFeature)
                    .WithMany(p => p.ProductfeatureFeature)
                    .HasForeignKey(d => d.ProductFeatureId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("productfeature_feature$FK3E6019BE3AA8E693");
            });

            modelBuilder.Entity<Productrelated>(entity =>
            {
                entity.ToTable("productrelated", "commandre");

                entity.Property(e => e.ProductRelatedId)
                    .HasColumnName("productRelated_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ProductAffiliatedId).HasColumnName("productAffiliatedId");
            });

            modelBuilder.Entity<Supplier>(entity =>
            {
                entity.ToTable("supplier", "commandre");

                entity.Property(e => e.SupplierId)
                    .HasColumnName("supplier_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);
            });
        }
    }
}