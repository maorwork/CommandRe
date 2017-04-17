using OnlineStore.Data.Repositories.Interfaces;
using OnlineStore.Domain.ShoppingCarts;

namespace OnlineStore.Data.Repositories
{

    public class ShoppingCartItemRepository : Repository<ShoppingCartItem>, IShoppingCartItemRepository
    {
        public ShoppingCartItemRepository(OnlineStoreContext context)
            : base(context)
        {
        }

        public OnlineStoreContext OnlineStoreContext
        {
            get { return _context as OnlineStoreContext; }
        }
    }
}
