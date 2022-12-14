using Furnits.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Furnits.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string ManagerName { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
