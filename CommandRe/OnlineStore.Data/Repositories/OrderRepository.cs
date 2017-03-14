using OnlineStore.Data.Repositories.Interfaces;
using OnlineStore.Domain.Orders;

namespace OnlineStore.Data.Repositories
{
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        public OrderRepository(OnlineStoreContext context)
            : base(context)
        {
        }

        public OnlineStoreContext OnlineStoreContext
        {
            get { return Context as OnlineStoreContext; }
        }
    }
}
