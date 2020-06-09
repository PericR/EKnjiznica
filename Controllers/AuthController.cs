using System;
using System.Threading.Tasks;
using EKnjiznica.Data;
using EKnjiznica.Dtos;
using EKnjiznica.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using Microsoft.EntityFrameworkCore;

namespace EKnjiznica.Controllers
{
    public class AuthController : Controller
    {
        private readonly DataContext _context;
        private readonly IAuthRepository _auth;

        public AuthController(DataContext context, IAuthRepository auth)
        {
            _auth = auth;
            _context = context;
        }

        public IActionResult Login()
        {
            if (!String.IsNullOrEmpty(HttpContext.Session.GetString("username")))
            {
                return RedirectToAction("Index", "Home");
            }

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login([Bind("Username, Password")] UserForLogin userForLogin)
        {
            if (!String.IsNullOrEmpty(HttpContext.Session.GetString("username")))
            {
                return RedirectToAction("Index", "Home");
            }

            var userFromBase = await _context.Users.FirstOrDefaultAsync(u => u.Username == userForLogin.Username);

            if (userFromBase != null && ModelState.IsValid)
            {
                if (_auth.ValidateUser(userFromBase, userForLogin.Password))
                {
                    SetSessionLogin(userFromBase);               
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("Username", "Wrong username or password");
                    return View(userForLogin);
                }
            }
            ModelState.AddModelError("Username", "Wrong username or password");
            return View(userForLogin);
        }

        public IActionResult Register()
        {
            if (!String.IsNullOrEmpty(HttpContext.Session.GetString("username")))
            {
                return RedirectToAction("Index", "Home");
            }

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> RegisterPost([Bind("Username, Password, ConfirmedPassword, FirstName, LastName, Email")] UserForRegister userForRegister)
        {
            if (!String.IsNullOrEmpty(HttpContext.Session.GetString("username")))
            {
                return RedirectToAction("Index", "Home");
            }

            if (ModelState.IsValid)
            {
                if (_auth.CheckUsername(userForRegister.Username))
                {
                    ModelState.AddModelError("Username", "Username taken");
                    return View("Register", userForRegister);
                }

                if(userForRegister.Password != userForRegister.ConfirmedPassword)
                {
                    ModelState.AddModelError("Password", "Password missmatch");
                    return View("Register", userForRegister);
                }

                User userToSave = _auth.CreateNewUser(userForRegister);
                _context.Users.Add(userToSave);
                await _context.SaveChangesAsync();
                
                SetSessionLogin(userToSave);
                return RedirectToAction("Login");
            }

            return View("Register", userForRegister);
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }

        private void SetSessionLogin(User user)
        {
            HttpContext.Session.SetString("username", user.Username);
            HttpContext.Session.SetString("id", user.Id.ToString());

            if(user.IsAdmin)
            {
                HttpContext.Session.SetString("role", "admin");
            }
            else
            {
                HttpContext.Session.SetString("role", "client");
            }
        }
    }
}