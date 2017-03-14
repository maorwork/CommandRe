using System.Collections.Generic;
using System.Linq;
using System;
using CommandRe.Domain.Products;
using OnlineStore.Data.Repositories.Interfaces;

namespace OnlineStore.Data.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(OnlineStoreContext context)
            : base(context)
        {
        }

        public IEnumerable<Product> GetTopSellingProduct(int count)
        {
            return OnlineStoreContext.Products.OrderByDescending(c => c.Orders.Count).Take(count).ToList();
        }

        public IEnumerable<Product> GetProductsByCategory(int count)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetProductsOrderedByName(int count)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetProductById(int id)
        {
            throw new NotImplementedException();
        }

        public OnlineStoreContext OnlineStoreContext
        {
            get { return Context as OnlineStoreContext; }
        }
    }
}
