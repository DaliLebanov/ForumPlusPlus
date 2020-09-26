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

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if(ModelState.IsValid)
            {
                if (_userService.Login(model).Succeeded)
                {
                    return RedirectToAction("Index", "home");
                }
                ModelState.AddModelError(string.Empty, "Username or Passwrod is incorrect");
            }
            return View(model);
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                _userService.Register(model);
                return RedirectToAction("Index", "home");
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
