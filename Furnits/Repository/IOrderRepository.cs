using Furnits.Data;
using Furnits.Models;
using Furnits.Models.Products;
using Furnits.Models.Products.Assortment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Furnits.Repository
{
    public interface IOrderRepository
    {
        public AppDbContext Context { get; }

        public IQueryable<Product> Products { get; }
        public IQueryable<Order> Orders { get; }
        public IQueryable<Divan> Divans { get; }
        public IQueryable<ProductType> ProductTypes { get; }
    }
}
