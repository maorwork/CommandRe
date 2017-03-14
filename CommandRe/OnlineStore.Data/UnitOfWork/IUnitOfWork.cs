using OnlineStore.Data.Repositories.Interfaces;
using System;

namespace OnlineStore.Data.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IUserAddressRepository UserAddress { get; }

        IProductRepository Products { get; }

        IOrderRepository Orders { get;  }
        IOrderItemRepository OrderItems { get; }

        IShoppingCartRepository ShoppingCarts { get; }
        IShoppingCartItemRepository ShoppingCartItems { get;  }
        int Complete();
    }
}
