using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ForumPP.DataAccess;
using ForumPP.DataAccess.DbModels;
using ForumPP.WebModels.AccontViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ForumPlusPlus.Controllers
{
  
    public class AccountController : Controller
    {
        private readonly IUserService _userService;


        public AccountController(IUserService userService)
        {
            _userService = userService;
        }

        public IActionResult Login(LoginViewModel model)
        {
            return View();
        }

        [HttpPost]
        public IActionResult LogIn(LoginViewModel model)
        {
            
            if (ModelState.IsValid)
            {
                _userService.Login(model);
                return RedirectToAction("Index", "Forum");
            }
            return View(model);
        }

        public IActionResult Register()
        {
            return View(new RegisterViewModel());
        }

        [HttpPost]
        public IActionResult Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                _userService.Register(model);
                return RedirectToAction("Index", "Forum");
            }
            return View(model);
        }
        public IActionResult LogOut()
        {
            _userService.Logout();
            return RedirectToAction("index", "home");
        }
    }
}
