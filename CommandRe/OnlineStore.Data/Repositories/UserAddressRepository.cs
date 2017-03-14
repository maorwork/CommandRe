using OnlineStore.Data.Repositories.Interfaces;
using OnlineStore.Domain.Users;

namespace OnlineStore.Data.Repositories
{

    public class UserAddressRepository : Repository<UserAddress>, IUserAddressRepository
    {
        public UserAddressRepository(OnlineStoreContext context)
            : base(context)
        {
        }

        public OnlineStoreContext OnlineStoreContext
        {
            get { return Context as OnlineStoreContext; }
        }
    }
}
