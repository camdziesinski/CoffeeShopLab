using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoffeeShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeShop.Controllers
{
    public class CoffeeShopController : Controller
    {
        public IActionResult Registration()
        {
            return View(new RegisterUser());
        }
        public IActionResult Summary(RegisterUser user)
        {
            //return View(user);
            if (ModelState.IsValid)
            {
                return View(user);
            }
            else
            {
                return View("Registration", user);
            }
        }
    }
}