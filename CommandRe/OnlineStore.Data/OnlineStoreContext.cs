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

        public DbSet<Product> Products { get; set; }

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
