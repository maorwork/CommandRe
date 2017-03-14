using OnlineStore.Data.Repositories.Interfaces;
using OnlineStore.Domain.Orders;

namespace OnlineStore.Data.Repositories
{

    public class OrderItemRepository : Repository<OrderItem>, IOrderItemRepository
    {
        public OrderItemRepository(OnlineStoreContext context)
            : base(context)
        {
        }

        public OnlineStoreContext OnlineStoreContext
        {
            get { return Context as OnlineStoreContext; }
        }
    }
}
