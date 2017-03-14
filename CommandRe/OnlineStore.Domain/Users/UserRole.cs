using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineStore.Domain.Users
{
    public class UserRole : IdentityRole<int>
    {
        public UserRole() : base() { }
    }
}
