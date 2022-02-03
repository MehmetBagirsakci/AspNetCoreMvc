using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MvcWebUI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcWebUI.Controllers
{
    public class AccountController : Controller
    {
        UserManager<CustomIdentityUser> _userManager;
        RoleManager<CustomIdentityRole> _roleManager;
        SignInManager<CustomIdentityUser> _signInManager;

        public AccountController(UserManager<CustomIdentityUser> userManager, RoleManager<CustomIdentityRole> roleManager, SignInManager<CustomIdentityUser> signInManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
