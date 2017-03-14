using Microsoft.AspNetCore.Identity;
using OnlineStore.Domain.Orders;
using OnlineStore.Domain.Users;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineStore.Data
{
    public class OnlineStoreIdentityInitialData
    {
        private OnlineStoreContext _context { get; set; }
        public OnlineStoreIdentityInitialData(OnlineStoreContext context, UserManager<User> userManager, RoleManager<UserRole> roleManager)
        {
            _context = context;
        }

        public async Task SeedData()
        {
            if (!_context.OrderStatus.Any())
            {
                var statusOptions = new[]
                {
                    new OrderStatus { Name = "New",},
                    new OrderStatus { Name = "Hold" },
                    new OrderStatus { Name = "Shipped" },
                    new OrderStatus { Name = "Delivered" },
                    new OrderStatus { Name = "Closed" },
                };

                _context.OrderStatus.AddRange(statusOptions);
                await _context.SaveChangesAsync();
            }

        }
    }
}
