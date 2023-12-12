using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Pustok.Core.Models;
using Pustok.ViewModels;

namespace Pustok.Controllers
{
    public class AccountController : Controller
    {
		private readonly UserManager<AppUser> _userManager;
		private readonly RoleManager<IdentityRole> _roleManager;
		private readonly SignInManager<AppUser> _signInManager;

		public AccountController(UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager, SignInManager<AppUser> signInManager)
        {
			_userManager = userManager;
			_roleManager = roleManager;
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
        public async Task<IActionResult> Login(MemberLoginViewModel memberLoginVM)
        {
            if(!ModelState.IsValid) return View();
            AppUser user = null;

            user = await _userManager.FindByNameAsync(memberLoginVM.Username);

            if(user == null)
            {
                ModelState.AddModelError("", "Invalid username or password");
                return View();
            }

            var result =  await _signInManager.PasswordSignInAsync(user, memberLoginVM.Password, false, false);

            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Invalid username or password");
                return View();
            }

            return RedirectToAction("index", "home");

        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(MemberRegisterViewModel memberRegisterVM)
        {
            if(!ModelState.IsValid) return View();
            AppUser user = null;

            user = await _userManager.FindByNameAsync(memberRegisterVM.Username);

            if(user is not null)
            {
                ModelState.AddModelError("Username", "Username already exist!");
                return View();
            }

            user = await _userManager.FindByEmailAsync(memberRegisterVM.Email);

            if(user is not null )
            {
				ModelState.AddModelError("Email", "Email already exist!");
				return View();
			}

            AppUser appUser = new AppUser
            {
                Fullname = memberRegisterVM.Fullname,
                UserName = memberRegisterVM.Username,
                Email = memberRegisterVM.Email,
                BirthDate = memberRegisterVM.Birthdate,
            };

            var result = await _userManager.CreateAsync(appUser,memberRegisterVM.Password);

            if(!result.Succeeded) 
            {
                foreach (var err in result.Errors)
                {
					ModelState.AddModelError("", err.Description);
					return View();
				}
            }

            await _userManager.AddToRoleAsync(appUser, "Member");
            await _signInManager.SignInAsync(appUser, isPersistent: false);

            return RedirectToAction("index", "Home");
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("index","home");
        }
    }
}
