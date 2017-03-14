
using OnlineStore.Data.Repositories;
using OnlineStore.Data.Repositories.Interfaces;

namespace OnlineStore.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly OnlineStoreContext _context;

        public UnitOfWork(OnlineStoreContext context)
        {
            _context = context;

            UserAddress = new UserAddressRepository(_context);
            Products = new ProductRepository(_context);

            Orders = new OrderRepository(_context);
            OrderItems = new OrderItemRepository(_context);

            ShoppingCarts = new ShoppingCartRepository(_context);
            ShoppingCartItems = new ShoppingCartItemRepository(_context);
        }

        public IUserAddressRepository UserAddress { get; set; }

        public IProductRepository Products { get; set; }

        public IOrderRepository Orders { get; set; }
        public IOrderItemRepository OrderItems { get; set; }

        public IShoppingCartRepository ShoppingCarts { get; set; }
        public IShoppingCartItemRepository ShoppingCartItems { get; set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
