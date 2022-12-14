using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Furnits.Models.Products.Assortment
{
    public class Divan
    {
        public int Id{ get; set; }
        public int BackDegree { get; set; }

        public int ProductsArticle { get; set; }
        public Product Product { get; set; }
    }
}
