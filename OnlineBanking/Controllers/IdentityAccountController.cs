using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OnlineBanking.Data;
using OnlineBanking.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OnlineBanking.Controllers
{
    public class IdentityAccountController : Controller
    {
        

        private UserManager<ApplicationUser> _userManager;
        private SignInManager<ApplicationUser> _signInManager;
        private RoleManager<IdentityRole> _roleManager;

        public IdentityAccountController(UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager, RoleManager<IdentityRole> roleManager)
        {
            //För att använda identity injectas dessa
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }


        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }


         [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Login(RegisterUserViewModel user)
        {
            if(ModelState.IsValid)
            {
                //Loggare in en användare
                var result = await _signInManager.PasswordSignInAsync(user.UserName, user.Password, true, false);

                if (result.Succeeded)
                {
                    //Om inloggningen gick bra visas startsidan
                    return RedirectToAction("Index", "Home");
                }

            }

            return View();
        }

        
        public async Task<IActionResult> LogOff()
        {

            await _signInManager.SignOutAsync();

            return RedirectToAction("Index" , "Home" );
        }

        [Authorize(Roles = "admin")]
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [Authorize(Roles = "admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterUserViewModel user)
        {
            if (ModelState.IsValid)
            {
                //Lägger över värdena från sidan i en ApplicationUser klass
                var userIdentity = new ApplicationUser { UserName = user.UserName };

                //Skapar användaren i databasen
                var result = await _userManager.CreateAsync(userIdentity, user.Password);

                //Kopplar användaren till en roll
                var resultRole = await _userManager.AddToRoleAsync(userIdentity, user.RoleName);

                //Om kontot har skapats logga in användaren. Då skapas cookies som skickas med 
                //i responsen 
                if (result.Succeeded)
                {
                    await _signInManager.SignInAsync(userIdentity, isPersistent: false);
                    return RedirectToAction("Statistics", "Customer");
                }

                
            }
            return View();
        }
    }
}
