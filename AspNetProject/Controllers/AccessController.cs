using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AspNetProject.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;

namespace AspNetProject.Controllers
{
    public class AccessController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            ClaimsPrincipal claimUser = HttpContext.User;
            if (claimUser.Identity.IsAuthenticated)
                return RedirectToAction("Index", "Home");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginData modelLogin)
        {
            if (
                modelLogin.Email == "abc@abc.pl" &&
                modelLogin.Password == "123"
            )
            {
                List<Claim> claims = new List<Claim>()
                {
                                  new Claim(ClaimTypes.NameIdentifier, modelLogin.Email),
                    new Claim("OtherProperties", "Example")
                };
                ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims,
                    CookieAuthenticationDefaults.AuthenticationScheme);
                AuthenticationProperties properties = new
                    AuthenticationProperties()
                    {
                        AllowRefresh = true,
                    };
                await
                    HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                        new ClaimsPrincipal(claimsIdentity), properties);
                return RedirectToAction("Index", "Home");
            }

            ViewData["ValidateMessage"] = "uzytkownik nieznaleziony";
            return View(modelLogin);
        }
    }
}