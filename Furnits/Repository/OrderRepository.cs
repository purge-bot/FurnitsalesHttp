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
        private AppDbContext context;
        public OrderRepository(AppDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Product> Products => context.Products;
        public IQueryable<Order> Orders => context.Orders;
        public IQueryable<Divan> Divans => context.Divans;
    }
}
