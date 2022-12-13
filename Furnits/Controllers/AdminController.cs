using Furnits.Models.Users;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Furnits.ViewModels;
using Microsoft.AspNetCore.Authorization;

namespace Furnits.Controllers
{
    [Authorize(Roles = "Admins")]
    public class AdminController : Controller
    {
        private UserManager<User> _userManager;

        public AdminController(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        public ViewResult Index()
        {
            return View(_userManager.Users);
        }

        public ViewResult Create() => View();

        [HttpPost]
        public async Task<IActionResult> Create(CreateModel model)
        {
            if(ModelState.IsValid)
            {
                User user = new User
                {
                    UserName = model.Name,
                    Email = model.Email
                };
                IdentityResult result = await _userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                    return RedirectToAction("Index");
                else
                {
                    foreach (IdentityError error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            return View(model);
        }
    }
}
