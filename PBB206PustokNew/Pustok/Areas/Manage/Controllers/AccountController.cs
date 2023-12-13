﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Pustok.Areas.ViewModels;
using Pustok.Core.Models;

namespace Pustok.Areas.Manage.Controllers
{
    [Area("manage")]
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(AdminLoginViewModel adminLoginVM)
        {
            if(!ModelState.IsValid) return View(adminLoginVM);

            AppUser admin = null;

            admin = await _userManager.FindByNameAsync(adminLoginVM.Username);

            if(admin is null)
            {
                ModelState.AddModelError("", "Invalid username or password!");
                return View();
            }
            var result =  await _signInManager.PasswordSignInAsync(admin, adminLoginVM.Password, false, false);

            if(!result.Succeeded) 
            {
                ModelState.AddModelError("", "Invalid username or password!");
                return View();
            }

            return RedirectToAction("Index", "Dashboard");
        }
    }
}
