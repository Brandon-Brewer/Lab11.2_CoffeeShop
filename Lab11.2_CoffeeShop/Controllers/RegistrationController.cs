using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Lab11._3_CoffeeShop.Controllers
{
    public class RegistrationController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View("RegistrationIndex");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Registration(string fname, string lname, string email, string phone, string passsword, string gender, bool over21, List<string> coffeeTypes)
        {
            if (ModelState.IsValid)
            {
                ViewData["name"] = fname + " " + lname;
                ViewData["email"] = email;
                ViewData["phone"] = phone;
                ViewData["password"] = passsword;
                ViewData["gender"] = gender;
                ViewData["over21"] = over21;
                ViewData["coffeeTypes"] = coffeeTypes;
                return View();
            }
            else
            {
                ViewData["errorMsg"] = "Your form had errors. Please correct and re-submit.";
                return View("RegistrationIndex");
            }
        }
    }
}