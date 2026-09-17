using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using WebAppTemplate.Helpers.Email;
using WebAppTemplate.ViewModels;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WebAppTemplate.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class AccountController : Controller
    {
        private readonly iEmailService _emailService;
        public AccountController(SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> userManager, iEmailService emailService)
        {
            SignInManager = signInManager;
            UserManager = userManager;
            _emailService = emailService;
        }

      
        SignInManager<IdentityUser> SignInManager { get; set; }
        UserManager<IdentityUser> UserManager { get; set; }


        public IActionResult Index()
        {
            return View();
        }


        [AllowAnonymous]
        public IActionResult LogIn()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]

        public async Task<IActionResult> LogIn(LogInViewModel Model)
        {
            // Check ==> user
            var Userdata = await UserManager.FindByNameAsync(Model.Username);

            if (Userdata == null)
            {
                return View(Model);
            }

            var res = await SignInManager.PasswordSignInAsync(Userdata, Model.Password, Model.RememberMe, false);

            if (res.Succeeded)
            {
                return RedirectToAction("Index", "Home");
            }

            return View(Model);
        }

        [AllowAnonymous]
        public IActionResult CreateUser()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> CreateUser(RegisterViewModel model)
        {

            //if(model.Password == model.PasswordConfirmation)
            //{}

            IdentityUser user = new IdentityUser();

            user.UserName = model.Username;
            user.Email = model.Email;

            var result = await UserManager.CreateAsync(user, model.Password);

            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Home");

            }

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> LogOut()
        {
            await SignInManager.SignOutAsync();
            return RedirectToAction(nameof(LogIn));
        }


        [AllowAnonymous]
        public IActionResult ForgotPassword()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> ForgotPassword(string  email)
        {
            if (ModelState.IsValid)
            {
                var UserData = await UserManager.FindByEmailAsync(email);

                if (UserData == null)
                {
                    return View(); 
                }

                var token = await UserManager.GeneratePasswordResetTokenAsync(UserData);

                var resetLink = Url.Action(
                    "ResetPassword",
                    "Account",
                    new
                    {
                        area = "Admin",
                        token = token,
                        email = UserData.Email
                    },
                     Request.Scheme
                );

                _emailService.SendEmail(
                    UserData.Email,
                    resetLink,
                    "Reset Password"
                );


            }
            return View("LogIn");
        }

        // GET
        [AllowAnonymous]
        public IActionResult ResetPassword(string token , string email)
        {
            if(token == null || email == null)
            {
                return BadRequest();
            }

            var model = new ResetPasswordViewModel
            {

                Token = token,
                Email = email
            };

            return View(model);
        }


        // POST
        [HttpPost]
        [AllowAnonymous]

        public async Task<IActionResult> ResetPassword(ResetPasswordViewModel model)
        {
            if (!ModelState.IsValid) { 
                return View(model);   
            }

            var user = await UserManager.FindByEmailAsync(model.Email);

            if (user == null) {
                return View(model);
            }

            var result = await UserManager.ResetPasswordAsync(
                user,
                model.Token,
                model.Password
            );

            if (result.Succeeded) {
                return RedirectToAction(nameof(LogIn));
            }

            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }

            return View(model);
        }
    }
}


