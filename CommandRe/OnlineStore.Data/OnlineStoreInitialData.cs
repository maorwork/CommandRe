using CommandRe.Domain.Products;
using Microsoft.AspNetCore.Identity;
using OnlineStore.Domain.Orders;
using OnlineStore.Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineStore.Data
{
    public class OnlineStoreInitialData
    {
        private RoleManager<UserRole> _roleManager;
        private OnlineStoreContext _context { get; set; }
        private UserManager<User> _userManager { get; set; }
        public OnlineStoreInitialData(OnlineStoreContext context, UserManager<User> userManager, RoleManager<UserRole> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        //public async Task SeedData()
        //{
        //    if (!_context.Users.Any() && !_context.Roles.Any())
        //    {
                
        //        var userAdmin = new User
        //        {
        //            FirstName = "Maor",
        //            LastName = "Eini",
        //            Gender = "M",
        //            DateOfBirth = new DateTime(1989, 11, 24),
        //            DateAdded = DateTime.Now,
        //            Email = "maor.eini@gmail.com",
        //            PhoneNumber = "0505335313",
        //            UserName = "maor.eini@gmail.com",
        //            UserAddress = new UserAddress { City = "Rishon Le Zion", BuildingNumber = "5 ", ApartmentNumber = "18", Province = "HaMerkaz", Street = "Kapah", State = "Israel", ZipCode = "7573006" },
        //            Orders = new HashSet<Order>(),
        //        };

        //        var userOrder = new Order
        //        {
        //            OrderedDate = DateTime.Now,
        //            ShippedDate = DateTime.Now,
        //            Status = _context.OrderStatus.Where(os => os.Name == "New").SingleOrDefault(),
        //            TotalPrice = 10,
        //            Products = new HashSet<OrderItem>(),
        //            ShippingAddress = userAdmin.UserAddress
        //        };


        //        var ProductOne = new Product
        //        {
                    
        //        };

        //        var ProductTwo = new Product
        //        {

        //        };

        //        var orderItemOne = new OrderItem
        //        {
        //            Order = userOrder,
        //            Product = ProductOne
        //        };

        //        var orderItemTwo = new OrderItem
        //        {
        //            Order = userOrder,
        //            Product = ProductTwo
        //        };

        //        userOrder.Products.Add(orderItemOne);
        //        userOrder.Products.Add(orderItemTwo);

        //        userAdmin.Orders.Add(userOrder);
        //        userAdmin.PasswordHash = new PasswordHasher<User>().HashPassword(userAdmin, "Maor123#@!");

        //        var userResult = await _userManager.CreateAsync(userAdmin);

        //        if (userResult.Succeeded)
        //        {
        //            var adminRole = new UserRole { Name = "Admin" };
        //            var adminResult = await _roleManager.CreateAsync(adminRole);

        //            if (adminResult.Succeeded)
        //            {
        //                var result = await _userManager.AddToRoleAsync(userAdmin, adminRole.Name);
        //                if (result.Succeeded)
        //                {
        //                    await _context.SaveChangesAsync();
        //                }
        //            }
        //        }
        //    }

        //}
    }
}
