using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using JonathanLogin.Models;

namespace JonathanLogin.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }



        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Authenticate(LoginViewModel model){
            if(ModelState.IsValid)
                return RedirectToAction("Index", "Home", new {email = model.Email});
            return View();            
        }
    }
}
