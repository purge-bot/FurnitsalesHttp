using Furnits.Models;
using Furnits.Models.Products;
using Furnits.Repository;
using Furnits.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Furnits.Controllers
{
    public class OrderController : Controller
    {
        private IOrderRepository _repository;

        public OrderController(IOrderRepository orderRepository)
        {
            _repository = orderRepository;
        }

        public IActionResult Index()
        {
            return View(_repository.Orders);
        }

        public IActionResult CreateOrder()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateOrder(CreateOrder viewModel)
        {
            if(ModelState.IsValid)
            {
                Order order = new Order()
                {
                    ManagerName = viewModel.ManagerName
                };
                _repository.Context.Add(order);
                int result = _repository.Context.SaveChanges();
                if (result > 0)
                    return RedirectToAction("Index");
            }
            return View(viewModel);
        }

        public IActionResult EditOrder(int orderId)
        {
            var item = from p in _repository.Orders
                       where p.Id == orderId
                       select p;
            Order ord = item.FirstOrDefault();
            return View(new EditOrder() { ManagerName = ord.ManagerName, OrderId = ord.Id });
        }

        [HttpPost]
        public IActionResult EditOrder(EditOrder viewModel)
        {
            var item = from p in _repository.Orders
                       where p.Id == viewModel.OrderId
                       select p;
            Order ord = item.FirstOrDefault();
            ord.ManagerName = viewModel.ManagerName;
            _repository.Context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult ProductList(int orderId)
        {
            var result = from p in _repository.Orders
                         where p.Id == orderId
                         select p.Products;

            return View(result);
        }
    }
}
