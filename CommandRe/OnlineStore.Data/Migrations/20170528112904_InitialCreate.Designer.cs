using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using OnlineStore.Data;

namespace OnlineStore.Data.Migrations
{
    [DbContext(typeof(OnlineStoreContext))]
    [Migration("20170528112904_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasDefaultSchema("ApplicationData")
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CommandRe.Domain.Products.Category", b =>
                {
                    b.Property<long>("CategoryId")
                        .HasColumnName("category_id");

                    b.HasKey("CategoryId");

                    b.ToTable("category","commandre");
                });

            modelBuilder.Entity("CommandRe.Domain.Products.Categoryfeaturegroup", b =>
                {
                    b.Property<long>("CategoryFeatureGroupId")
                        .HasColumnName("categoryFeatureGroup_id");

                    b.HasKey("CategoryFeatureGroupId");

                    b.ToTable("categoryfeaturegroup","commandre");
                });

            modelBuilder.Entity("CommandRe.Domain.Products.CategoryfeaturegroupFeaturegroup", b =>
                {
                    b.Property<long>("CategoryFeatureGroupId")
                        .HasColumnName("categoryFeatureGroup_id");

                    b.Property<long>("FeatureGroupId")
                        .HasColumnName("featureGroup_id");

                    b.HasKey("CategoryFeatureGroupId", "FeatureGroupId")
                        .HasName("PK_categoryfeaturegroup_featuregroup_categoryFeatureGroup_id");

                    b.HasIndex("CategoryFeatureGroupId");

                    b.HasIndex("FeatureGroupId");

                    b.ToTable("categoryfeaturegroup_featuregroup","commandre");
                });

            modelBuilder.Entity("CommandRe.Domain.Products.CategoryName", b =>
                {
                    b.Property<long>("CategoryId")
                        .HasColumnName("category_id");

                    b.Property<long>("NameId")
                        .HasColumnName("name_id");

                    b.HasKey("CategoryId", "NameId")
                        .HasName("PK_category_name_category_id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("NameId");

                    b.ToTable("category_name","commandre");
                });

            modelBuilder.Entity("CommandRe.Domain.Products.Feature", b =>
                {
                    b.Property<long>("FeatureId")
                        .HasColumnName("feature_id");

                    b.HasKey("FeatureId");

                    b.ToTable("feature","commandre");
                });

            modelBuilder.Entity("CommandRe.Domain.Products.Featuregroup", b =>
                {
                    b.Property<long>("FeatureGroupId")
                        .HasColumnName("featureGroup_id");

                    b.HasKey("FeatureGroupId");

                    b.ToTable("featuregroup","commandre");
                });

            modelBuilder.Entity("CommandRe.Domain.Products.FeaturegroupName", b =>
                {
                    b.Property<long>("FeatureGroupId")
                        .HasColumnName("featureGroup_id");

                    b.Property<long>("NameId")
                        .HasColumnName("name_id");

                    b.HasKey("FeatureGroupId", "NameId")
                        .HasName("PK_featuregroup_name_featureGroup_id");

                    b.HasIndex("FeatureGroupId");

                    b.HasIndex("NameId");

                    b.ToTable("featuregroup_name","commandre");
                });

            modelBuilder.Entity("CommandRe.Domain.Products.FeatureName", b =>
                {
                    b.Property<long>("FeatureId")
                        .HasColumnName("feature_id");

                    b.Property<long>("NameId")
                        .HasColumnName("name_id");

                    b.HasKey("FeatureId", "NameId")
                        .HasName("PK_feature_name_feature_id");

                    b.HasIndex("FeatureId");

                    b.HasIndex("NameId");

                    b.ToTable("feature_name","commandre");
                });

            modelBuilder.Entity("CommandRe.Domain.Products.Name", b =>
                {
                    b.Property<long>("NameId")
                        .HasColumnName("name_id");

                    b.Property<string>("Value")
                        .HasColumnName("value");

                    b.HasKey("NameId");

                    b.ToTable("name","commandre");
                });

            modelBuilder.Entity("CommandRe.Domain.Products.Product", b =>
                {
                    b.Property<long>("ProductId")
                        .HasColumnName("product_id");

                    b.Property<string>("HighPic")
                        .HasColumnName("highPic")
                        .HasMaxLength(255);

                    b.Property<string>("Name")
                        .HasColumnName("name")
                        .HasMaxLength(255);

                    b.Property<string>("Quality")
                        .HasColumnName("quality")
                        .HasMaxLength(255);

                    b.Property<DateTime?>("ReleaseDate")
                        .HasColumnName("releaseDate")
                        .HasColumnType("date");

                    b.Property<long?>("SupplierId")
                        .HasColumnName("supplier_id");

                    b.Property<string>("Title")
                        .HasColumnName("title")
                        .HasMaxLength(255);

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnName("updateDate")
                        .HasColumnType("date");

                    b.HasKey("ProductId");

                    b.HasIndex("SupplierId");

                    b.ToTable("product","commandre");
                });

            modelBuilder.Entity("CommandRe.Domain.Products.ProductCategory", b =>
                {
                    b.Property<long>("ProductId")
                        .HasColumnName("product_id");

                    b.Property<long>("CategoryId")
                        .HasColumnName("category_id");

                    b.HasKey("ProductId", "CategoryId")
                        .HasName("PK_product_category_product_id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ProductId");

                    b.ToTable("product_category","commandre");
                });

            modelBuilder.Entity("CommandRe.Domain.Products.ProductCategoryfeaturegroup", b =>
                {
                    b.Property<long>("ProductId")
                        .HasColumnName("product_id");

                    b.Property<long>("CategoryFeatureGroupId")
                        .HasColumnName("categoryFeatureGroup_id");

                    b.HasKey("ProductId", "CategoryFeatureGroupId")
                        .HasName("PK_product_categoryfeaturegroup_product_id");

                    b.HasIndex("CategoryFeatureGroupId");

                    b.HasIndex("ProductId");

                    b.ToTable("product_categoryfeaturegroup","commandre");
                });

            modelBuilder.Entity("CommandRe.Domain.Products.Productdescription", b =>
                {
                    b.Property<long>("DescriptionId")
                        .HasColumnName("description_id");

                    b.Property<string>("LongDescription")
                        .HasColumnName("longDescription");

                    b.Property<string>("PdfUrl")
                        .HasColumnName("pdfUrl")
                        .HasMaxLength(255);

                    b.Property<string>("ShortDescription")
                        .HasColumnName("shortDescription");

                    b.Property<string>("Url")
                        .HasColumnName("url")
                        .HasMaxLength(255);

                    b.HasKey("DescriptionId")
                        .HasName("PK_productdescription_description_id");

                    b.ToTable("productdescription","commandre");
                });

            modelBuilder.Entity("CommandRe.Domain.Products.Productfeature", b =>
                {
                    b.Property<long>("ProductFeatureId")
                        .HasColumnName("productFeature_id");

                    b.Property<string>("PresentationValue")
                        .HasColumnName("presentationValue");

                    b.HasKey("ProductFeatureId");

                    b.ToTable("productfeature","commandre");
                });

            modelBuilder.Entity("CommandRe.Domain.Products.ProductfeatureFeature", b =>
                {
                    b.Property<long>("ProductFeatureId")
                        .HasColumnName("productFeature_id");

                    b.Property<long>("FeatureId")
                        .HasColumnName("feature_id");

                    b.HasKey("ProductFeatureId", "FeatureId")
                        .HasName("PK_productfeature_feature_productFeature_id");

                    b.HasIndex("FeatureId");

                    b.HasIndex("ProductFeatureId");

                    b.ToTable("productfeature_feature","commandre");
                });

            modelBuilder.Entity("CommandRe.Domain.Products.ProductProductdescription", b =>
                {
                    b.Property<long>("ProductId")
                        .HasColumnName("product_id");

                    b.Property<long>("DescriptionId")
                        .HasColumnName("description_id");

                    b.HasKey("ProductId", "DescriptionId")
                        .HasName("PK_product_productdescription_product_id");

                    b.HasIndex("DescriptionId");

                    b.HasIndex("ProductId");

                    b.ToTable("product_productdescription","commandre");
                });

            modelBuilder.Entity("CommandRe.Domain.Products.ProductProductfeature", b =>
                {
                    b.Property<long>("ProductId")
                        .HasColumnName("product_id");

                    b.Property<long>("ProductFeatureId")
                        .HasColumnName("productFeature_id");

                    b.HasKey("ProductId", "ProductFeatureId")
                        .HasName("PK_product_productfeature_product_id");

                    b.HasIndex("ProductFeatureId");

                    b.HasIndex("ProductId");

                    b.ToTable("product_productfeature","commandre");
                });

            modelBuilder.Entity("CommandRe.Domain.Products.ProductProductrelated", b =>
                {
                    b.Property<long>("ProductId")
                        .HasColumnName("product_id");

                    b.Property<long>("ProductRelatedId")
                        .HasColumnName("productRelated_id");

                    b.HasKey("ProductId", "ProductRelatedId")
                        .HasName("PK_product_productrelated_product_id");

                    b.HasIndex("ProductId");

                    b.HasIndex("ProductRelatedId");

                    b.ToTable("product_productrelated","commandre");
                });

            modelBuilder.Entity("CommandRe.Domain.Products.Productrelated", b =>
                {
                    b.Property<long>("ProductRelatedId")
                        .HasColumnName("productRelated_id");

                    b.Property<long?>("ProductAffiliatedId")
                        .HasColumnName("productAffiliatedId");

                    b.HasKey("ProductRelatedId");

                    b.ToTable("productrelated","commandre");
                });

            modelBuilder.Entity("CommandRe.Domain.Products.Supplier", b =>
                {
                    b.Property<long>("SupplierId")
                        .HasColumnName("supplier_id");

                    b.Property<string>("Name")
                        .HasColumnName("name")
                        .HasMaxLength(255);

                    b.HasKey("SupplierId");

                    b.ToTable("supplier","commandre");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<int>("RoleId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("RoleClaims","User");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserClaims","User");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<int>("UserId");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("UserLogins","User");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<int>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles","User");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("UserTokens","User");
                });

            modelBuilder.Entity("OnlineStore.Domain.Orders.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("OrderedDate");

                    b.Property<DateTime>("ShippedDate");

                    b.Property<int>("ShippingAddressId");

                    b.Property<int>("StatusId");

                    b.Property<double>("TotalPrice");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("ShippingAddressId");

                    b.HasIndex("StatusId");

                    b.HasIndex("UserId");

                    b.ToTable("Orders","Order");
                });

            modelBuilder.Entity("OnlineStore.Domain.Orders.OrderItem", b =>
                {
                    b.Property<int>("OrderId");

                    b.Property<long>("ProductId");

                    b.Property<int>("Quantity");

                    b.HasKey("OrderId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderItems","Order");
                });

            modelBuilder.Entity("OnlineStore.Domain.Orders.OrderStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("OrderStatus","Order");
                });

            modelBuilder.Entity("OnlineStore.Domain.ShoppingCarts.ShoppingCart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateCreated");

                    b.Property<int>("UserAccountId");

                    b.HasKey("Id");

                    b.HasIndex("UserAccountId")
                        .IsUnique();

                    b.ToTable("ShoppingCarts","User");
                });

            modelBuilder.Entity("OnlineStore.Domain.ShoppingCarts.ShoppingCartItem", b =>
                {
                    b.Property<int>("ShoppingCartId");

                    b.Property<long>("ProductId");

                    b.Property<int>("Quantity");

                    b.HasKey("ShoppingCartId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("ShoppingCartItems","User");
                });

            modelBuilder.Entity("OnlineStore.Domain.Users.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("UserId");

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<DateTime>("DateAdded");

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName")
                        .HasMaxLength(255);

                    b.Property<string>("Gender")
                        .HasMaxLength(1);

                    b.Property<string>("IsActive")
                        .HasMaxLength(1);

                    b.Property<string>("LastName")
                        .HasMaxLength(255);

                    b.Property<DateTime>("LastUpdated");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PasswordOld");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<int>("UserAddressId");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("Accounts","User");
                });

            modelBuilder.Entity("OnlineStore.Domain.Users.UserAddress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ApartmentNumber");

                    b.Property<string>("BuildingNumber");

                    b.Property<string>("City");

                    b.Property<string>("Province");

                    b.Property<string>("State");

                    b.Property<string>("Street");

                    b.Property<int>("UserAccountId");

                    b.Property<string>("ZipCode");

                    b.HasKey("Id");

                    b.HasIndex("UserAccountId")
                        .IsUnique();

                    b.ToTable("Addresses","User");
                });

            modelBuilder.Entity("OnlineStore.Domain.Users.UserRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("Roles","User");
                });

            modelBuilder.Entity("CommandRe.Domain.Products.CategoryfeaturegroupFeaturegroup", b =>
                {
                    b.HasOne("CommandRe.Domain.Products.Categoryfeaturegroup", "CategoryFeatureGroup")
                        .WithMany("CategoryfeaturegroupFeaturegroup")
                        .HasForeignKey("CategoryFeatureGroupId");

                    b.HasOne("CommandRe.Domain.Products.Featuregroup", "FeatureGroup")
                        .WithMany("CategoryfeaturegroupFeaturegroup")
                        .HasForeignKey("FeatureGroupId");
                });

            modelBuilder.Entity("CommandRe.Domain.Products.CategoryName", b =>
                {
                    b.HasOne("CommandRe.Domain.Products.Category", "Category")
                        .WithMany("CategoryName")
                        .HasForeignKey("CategoryId");

                    b.HasOne("CommandRe.Domain.Products.Name", "Name")
                        .WithMany("CategoryName")
                        .HasForeignKey("NameId");
                });

            modelBuilder.Entity("CommandRe.Domain.Products.FeaturegroupName", b =>
                {
                    b.HasOne("CommandRe.Domain.Products.Featuregroup", "FeatureGroup")
                        .WithMany("FeaturegroupName")
                        .HasForeignKey("FeatureGroupId");

                    b.HasOne("CommandRe.Domain.Products.Name", "Name")
                        .WithMany("FeaturegroupName")
                        .HasForeignKey("NameId");
                });

            modelBuilder.Entity("CommandRe.Domain.Products.FeatureName", b =>
                {
                    b.HasOne("CommandRe.Domain.Products.Feature", "Feature")
                        .WithMany("FeatureName")
                        .HasForeignKey("FeatureId");

                    b.HasOne("CommandRe.Domain.Products.Name", "Name")
                        .WithMany("FeatureName")
                        .HasForeignKey("NameId");
                });

            modelBuilder.Entity("CommandRe.Domain.Products.Product", b =>
                {
                    b.HasOne("CommandRe.Domain.Products.Supplier", "Supplier")
                        .WithMany("Product")
                        .HasForeignKey("SupplierId");
                });

            modelBuilder.Entity("CommandRe.Domain.Products.ProductCategory", b =>
                {
                    b.HasOne("CommandRe.Domain.Products.Category", "Category")
                        .WithMany("ProductCategory")
                        .HasForeignKey("CategoryId");

                    b.HasOne("CommandRe.Domain.Products.Product", "Product")
                        .WithMany("ProductCategory")
                        .HasForeignKey("ProductId");
                });

            modelBuilder.Entity("CommandRe.Domain.Products.ProductCategoryfeaturegroup", b =>
                {
                    b.HasOne("CommandRe.Domain.Products.Categoryfeaturegroup", "CategoryFeatureGroup")
                        .WithMany("ProductCategoryfeaturegroup")
                        .HasForeignKey("CategoryFeatureGroupId");

                    b.HasOne("CommandRe.Domain.Products.Product", "Product")
                        .WithMany("ProductCategoryfeaturegroup")
                        .HasForeignKey("ProductId");
                });

            modelBuilder.Entity("CommandRe.Domain.Products.ProductfeatureFeature", b =>
                {
                    b.HasOne("CommandRe.Domain.Products.Feature", "Feature")
                        .WithMany("ProductfeatureFeature")
                        .HasForeignKey("FeatureId");

                    b.HasOne("CommandRe.Domain.Products.Productfeature", "ProductFeature")
                        .WithMany("ProductfeatureFeature")
                        .HasForeignKey("ProductFeatureId");
                });

            modelBuilder.Entity("CommandRe.Domain.Products.ProductProductdescription", b =>
                {
                    b.HasOne("CommandRe.Domain.Products.Productdescription", "Description")
                        .WithMany("ProductProductdescription")
                        .HasForeignKey("DescriptionId");

                    b.HasOne("CommandRe.Domain.Products.Product", "Product")
                        .WithMany("ProductProductdescription")
                        .HasForeignKey("ProductId");
                });

            modelBuilder.Entity("CommandRe.Domain.Products.ProductProductfeature", b =>
                {
                    b.HasOne("CommandRe.Domain.Products.Productfeature", "ProductFeature")
                        .WithMany("ProductProductfeature")
                        .HasForeignKey("ProductFeatureId");

                    b.HasOne("CommandRe.Domain.Products.Product", "Product")
                        .WithMany("ProductProductfeature")
                        .HasForeignKey("ProductId");
                });

            modelBuilder.Entity("CommandRe.Domain.Products.ProductProductrelated", b =>
                {
                    b.HasOne("CommandRe.Domain.Products.Product", "Product")
                        .WithMany("ProductProductrelated")
                        .HasForeignKey("ProductId");

                    b.HasOne("CommandRe.Domain.Products.Productrelated", "ProductRelated")
                        .WithMany("ProductProductrelated")
                        .HasForeignKey("ProductRelatedId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("OnlineStore.Domain.Users.UserRole")
                        .WithMany("Claims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("OnlineStore.Domain.Users.User")
                        .WithMany("Claims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("OnlineStore.Domain.Users.User")
                        .WithMany("Logins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<int>", b =>
                {
                    b.HasOne("OnlineStore.Domain.Users.UserRole")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OnlineStore.Domain.Users.User")
                        .WithMany("Roles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OnlineStore.Domain.Orders.Order", b =>
                {
                    b.HasOne("OnlineStore.Domain.Users.UserAddress", "ShippingAddress")
                        .WithMany("Orders")
                        .HasForeignKey("ShippingAddressId");

                    b.HasOne("OnlineStore.Domain.Orders.OrderStatus", "Status")
                        .WithMany("Orders")
                        .HasForeignKey("StatusId");

                    b.HasOne("OnlineStore.Domain.Users.User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OnlineStore.Domain.Orders.OrderItem", b =>
                {
                    b.HasOne("OnlineStore.Domain.Orders.Order", "Order")
                        .WithMany("Products")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CommandRe.Domain.Products.Product", "Product")
                        .WithMany("Orders")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OnlineStore.Domain.ShoppingCarts.ShoppingCart", b =>
                {
                    b.HasOne("OnlineStore.Domain.Users.User", "UserAccount")
                        .WithOne("ShoppingCart")
                        .HasForeignKey("OnlineStore.Domain.ShoppingCarts.ShoppingCart", "UserAccountId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OnlineStore.Domain.ShoppingCarts.ShoppingCartItem", b =>
                {
                    b.HasOne("CommandRe.Domain.Products.Product", "Product")
                        .WithMany("ShoppingCarts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OnlineStore.Domain.ShoppingCarts.ShoppingCart", "ShoppingCart")
                        .WithMany("ShoppingCartItems")
                        .HasForeignKey("ShoppingCartId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OnlineStore.Domain.Users.UserAddress", b =>
                {
                    b.HasOne("OnlineStore.Domain.Users.User", "UserAccount")
                        .WithOne("UserAddress")
                        .HasForeignKey("OnlineStore.Domain.Users.UserAddress", "UserAccountId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
