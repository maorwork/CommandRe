using CommandRe.Domain.Products;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
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


            builder.Entity<Order>().ConfigureOrder();

            builder.Entity<OrderItem>().ConfigureOrdersItem();

            builder.Entity<OrderStatus>().ConfigureOrderStatus();


            builder.Entity<ShoppingCart>().ConfigureShoppingCart();

            builder.Entity<ShoppingCartItem>().ConfigureShoppingCartItem();

        }
    }
}
