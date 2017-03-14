using System.Linq;
using Microsoft.EntityFrameworkCore;
using OnlineStore.Domain.ShoppingCarts;
using OnlineStore.Data.Repositories.Interfaces;

namespace OnlineStore.Data.Repositories
{
    public class ShoppingCartRepository : Repository<ShoppingCart>, IShoppingCartRepository
    {
        public ShoppingCartRepository(OnlineStoreContext context)
            : base(context)
        {
        }

        public OnlineStoreContext OnlineStoreContext
        {
            get { return Context as OnlineStoreContext; }
        }

        public ShoppingCart GetShoppingCartByUserId(int userId)
        {
            return OnlineStoreContext.ShoppingCarts
                .Include(sc=> sc.ShoppingCartItems)
                .ThenInclude(sci => sci.Product)
                .Where(sc => sc.UserAccountId == userId)
                .OrderByDescending(sc => sc.DateCreated)
                .FirstOrDefault();
        }

        public ShoppingCart GetShoppingCartProductsByUserId(int userId)
        {
            return OnlineStoreContext.ShoppingCarts
                    .Where(sc => sc.UserAccountId == userId)
                    .OrderByDescending(sc => sc.DateCreated)
                    .FirstOrDefault();
        }
    }
}
