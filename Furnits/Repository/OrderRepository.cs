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
    public class OrderRepository : IOrderRepository
    {
        public AppDbContext Context { get; }
        public OrderRepository(AppDbContext ctx)
        {
            Context = ctx;
        }
        public IQueryable<Product> Products => Context.Products;
        public IQueryable<Order> Orders => Context.Orders;
        public IQueryable<Divan> Divans => Context.Divans;

    }
}
