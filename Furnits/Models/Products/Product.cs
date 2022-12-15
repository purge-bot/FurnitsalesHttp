using Furnits.Models.Products.Assortment;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Furnits.Models.Products
{
    public class Product
    {
        [Key]
        public int Article { get; set; }
        public string ProductName { get; set; }
        public int Length { get; set; }
        public int Width { get; set; }
        public ICollection<Order> Orders { get; set; }
        public Divan Divan { get; set; }

        public int ProductTypeId { get; set; }
        public ProductType ProductType { get; set; }
    }
}
