using Blog.Models;
using Blog.Services;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers
{
    public class LoginController : Controller
    {
        private readonly IAuthenticationService authenticationService;

        public LoginController(IAuthenticationService authenticationService)
        {
            this.authenticationService = authenticationService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(UserViewModel user)
        {
            if (ModelState.IsValid) 
            {
                var token = authenticationService.AuthenticateUser(user.Email, user.Password);

                if (token != null) 
                {
                    return RedirectToAction("Index", "Home");
                }

                else
                {
                    TempData["loginError"] = "Invalid Credentials";
                }
            }

            return View(user);
        }
    }
}
