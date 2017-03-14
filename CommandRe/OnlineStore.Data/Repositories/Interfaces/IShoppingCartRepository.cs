using OnlineStore.Domain.ShoppingCarts;

namespace OnlineStore.Data.Repositories.Interfaces
{
    public interface IShoppingCartRepository : IRepository<ShoppingCart>
    {
        ShoppingCart GetShoppingCartByUserId(int id);
        ShoppingCart GetShoppingCartProductsByUserId(int id);
    }
}
