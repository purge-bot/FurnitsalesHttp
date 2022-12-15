using Furnits.Models;
using Furnits.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Furnits.ViewModels
{
    public class CreateOrder
    {
        public string ManagerName { get; set; }
    }

    public class EditOrder
    {
        public int OrderId { get; set; }
        public string ManagerName { get; set; }
        public int ProductId{ get; set; }
    }
}
