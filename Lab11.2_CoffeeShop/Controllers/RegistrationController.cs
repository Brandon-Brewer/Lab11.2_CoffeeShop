using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Lab11._2_CoffeeShop.Controllers
{
    public class RegistrationController : Controller
    {
        public IActionResult Index()
        {
            return View("RegistrationIndex");
        }

        [HttpPost]
        public IActionResult Registration(string fname, string lname, string email, string phone, string passsword)
        {
            ViewData["name"] = fname + " " + lname;
            ViewData["email"] = email;
            return View();
        }
    }
}