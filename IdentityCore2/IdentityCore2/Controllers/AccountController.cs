using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityCore2.Models;
using IdentityCore2.Models.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace IdentityCore2.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly RoleManager<ApplicationRole> _roleManager;

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, RoleManager<ApplicationRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }


        public IActionResult Index()
        {
            _roleManager.CreateAsync(new ApplicationRole() {
                Id=Guid.NewGuid().ToString(),
                Name="User"
            });

            return View();
        }

        public IActionResult LogOut()
        {
            _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user != null)
            {
                await _signInManager.PasswordSignInAsync(user, model.Password, false, false);
            }

            return RedirectToAction("Index", "Home");
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            var user = new ApplicationUser()
            {
                Email = model.Email,
                UserName = model.UserName
            };

            var identityResult = await _userManager.CreateAsync(user, model.Password);

            if(identityResult.Succeeded)
            {
                await _userManager.AddToRoleAsync(user, "User");
            }

            return View();
        }


        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}