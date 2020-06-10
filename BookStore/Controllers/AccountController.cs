using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BookStore.Controllers
{
    public class AccountController : Controller
    {
        private readonly AppDataContext _context;

        public AccountController(AppDataContext context)
        {
            _context = context;
        }

        public IActionResult Signin()
        {
            return View("Login");
        }
        public IActionResult Signup()
        {
            return View("Register");
        }
        [HttpPost]
        public IActionResult Login()
        {
            if (ModelState.IsValid)
            {
                string email = HttpContext.Request.Form["email"];
                string password = HttpContext.Request.Form["password"];

                var user = _context.Account.Where(m => m.Email.Equals(email) && m.Password.Equals(password)).FirstOrDefault();
                if (user == null)
                {
                    ViewData["message"] = "Password invalid login attempt.";
                    return View("Login");
                }
                HttpContext.Session.SetString("userId", user.Name);
            }
            else
            {
                ViewData["message"] = "Username, Password Invalid.";
                return View("Login");
            }
            return RedirectToAction("Index", "Home");
        }
        [HttpPost]
        public IActionResult Register()
        {
            var valid = true;
            string fullName = HttpContext.Request.Form["fullName"];
            string email = HttpContext.Request.Form["email"];
            string password = HttpContext.Request.Form["password"];

            if (fullName.Length < 6 || email.Length < 6 || password.Length < 6 ||
                fullName.Length > 30 || email.Length > 30 || password.Length > 30)
                valid = false;
            if (valid)
            {
                Account user = new Account
                {
                    Name = fullName,
                    Email = email,
                    Password = password,
                };
                _context.Add(user);
                _context.SaveChangesAsync();
            }
            else
            {
                ViewData["message"] = "Username, Password Invalid.";
                return View("Register");
            }
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }
    }
}
