using Furnits.Models;
using Furnits.Models.Products;
using Furnits.Models.Products.Assortment;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Furnits.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Divan> Divans { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Product>().HasKey(key => key.Article);
            builder.Entity<Product>().HasOne(b => b.Divan).WithOne(i => i.Product).HasForeignKey<Divan>(b => b.ProductsArticle);
            //builder.Entity<Divan>().HasKey(key => key.ProductsArticle);
        }

    }
}
