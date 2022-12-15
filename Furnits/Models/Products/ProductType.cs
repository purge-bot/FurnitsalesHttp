using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Furnits.Models.Products
{
    public class ProductType
    {
        public int Id { get; set; }
        public string TypeName { get; set; }

        public int ProductArticle { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
