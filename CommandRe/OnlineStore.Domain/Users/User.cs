using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using OnlineStore.Domain.Orders;
using OnlineStore.Domain.ShoppingCarts;

namespace OnlineStore.Domain.Users
{
    public class User : IdentityUser<int>
    {
        public User() : base()
        {
            Orders = new HashSet<Order>();
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PasswordOld { get; set; }
        public string IsActive { get; set; }
        public int UserAddressId { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime LastUpdated { get; set; }

        public virtual ShoppingCart ShoppingCart { get; set; }
        public virtual UserAddress UserAddress { get; set; }
        public virtual ICollection<Order> Orders { get; set; }

    }
}
