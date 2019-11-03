using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pato_Palace.DAL;
using Pato_Palace.Models;
using Pato_Palace.Utilities;
using Pato_Palace.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Pato_Palace.Controllers
{
    public class AccountController : Controller
    {
        private Pato_PalaceDbContext _context;
        private UserManager<AppUser> _userManager;
        private SignInManager<AppUser> _signInManager;
        private RoleManager<IdentityRole> _roleManager;
        public AccountController(Pato_PalaceDbContext context, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            
        }
        
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel registerViewModel)
        {
            if (!ModelState.IsValid) return View(registerViewModel);

            AppUser newUser = new AppUser()
            {
                Name = registerViewModel.Name,
                Surname = registerViewModel.Surname,
                Email = registerViewModel.Email,
                UserName = registerViewModel.Username,
            };

            await RoleSeeder();

            IdentityResult identityresult = await _userManager.CreateAsync(newUser, registerViewModel.Password);

            if (!identityresult.Succeeded)
            {
                foreach (var error in identityresult.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View(registerViewModel);
            }
          

            await _userManager.AddToRoleAsync(newUser, Utility.Roles.Member.ToString());

            await _signInManager.SignInAsync(newUser, true);
            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();

            return RedirectToAction("Index", "Home");
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Login(LoginViewModel loginViewModel)
        {
            if (!ModelState.IsValid) return View(loginViewModel);
            AppUser user = await _userManager.FindByEmailAsync(loginViewModel.Email);
            if (user == null)
            {
                ModelState.AddModelError("", "Email or password wrong");
                return View(loginViewModel);
            }

            Microsoft.AspNetCore.Identity.SignInResult signInResult = await _signInManager.PasswordSignInAsync
                (user, loginViewModel.Password, loginViewModel.RememberMe, true);

            if (!signInResult.Succeeded)
            {
                ModelState.AddModelError("", "Email or password wrong");
                return View(loginViewModel);
            }
            else
            {
                var roleManager = await _userManager.GetRolesAsync(user);
                foreach (var item in roleManager)
                {
                    if (item == Utility.Roles.Admin.ToString())
                    {
                        return RedirectToAction("Index", "Pato_Palace_Admin");
                    }
                }
            }

            return RedirectToAction("Index", "Home");
        }


        public async Task RoleSeeder()
        {

            if (!await _roleManager.RoleExistsAsync(Utility.Roles.Admin.ToString()))
            {
                await _roleManager.CreateAsync(new IdentityRole(Utility.Roles.Admin.ToString()));
            }
            if (!await _roleManager.RoleExistsAsync(Utility.Roles.Manager.ToString()))
            {
                await _roleManager.CreateAsync(new IdentityRole(Utility.Roles.Manager.ToString()));
            }
            if (!await _roleManager.RoleExistsAsync(Utility.Roles.Member.ToString()))
            {
                await _roleManager.CreateAsync(new IdentityRole(Utility.Roles.Member.ToString()));
            }
        }




    }
}