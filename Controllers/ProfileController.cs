using EKnjiznica.Data;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using EKnjiznica.Dtos;
using EKnjiznica.Models;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;

namespace EKnjiznica.Controllers
{
    public class ProfileController : Controller
    {
        private readonly DataContext _context;
        private readonly IAuthRepository _auth;
        public ProfileController(DataContext context, IAuthRepository auth)
        {
            _auth = auth;
            _context = context;
        }

        public async Task<IActionResult> Profile()
        {
            if (String.IsNullOrEmpty(HttpContext.Session.GetString("username")))
            {
                return RedirectToAction("Index", "Home");
            }

            int userId = Int16.Parse(HttpContext.Session.GetString("id"));
            User user = await _context.Users.FindAsync(userId);
            var payments = from p in _context.Payments
                           where p.UserId == userId && p.PaymentOver == true
                           select p;
            var transactions = from t in _context.Transactions
                               where t.ClientId == userId
                               select t;

            ProfileViewModel profileViewModel = new ProfileViewModel
            {
                FullName = user.FirstName + " " + user.LastName,
                Username = user.Username,
                Email = user.Email,
                AccountBalance = user.AccountBalance,
                Transactions = transactions.ToList(),
                Payments = payments.ToList(),
                Books = new List<Book>()
            };

            foreach (Payment p in payments)
            {
                Book book = await _context.Books.FindAsync(p.BookId);
                profileViewModel.Books.Add(book);
            }

            return View(profileViewModel);
        }

        public async Task<IActionResult> Basket()
        {
            if (String.IsNullOrEmpty(HttpContext.Session.GetString("username")))
            {
                return RedirectToAction("Index", "Home");
            }

            int userId = int.Parse(HttpContext.Session.GetString("id"));
            var payments = from p in _context.Payments
                           where p.UserId == userId && p.PaymentOver == false
                           select p;
            User user = await _context.Users.FindAsync(userId);


            double totalPrice = 0;
            foreach (Payment p in payments)
            {
                totalPrice += p.BookPrice;
            }

            BasketViewModel basketViewModel = new BasketViewModel
            {
                Payments = payments.ToList(),
                TotalPrice = totalPrice,
                CurrentBallance = user.AccountBalance,
                NewBallance = user.AccountBalance - totalPrice,
                UserName = user.FirstName + " " + user.LastName
            };

            return View(basketViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> AddToBasket(int id)
        {
            if (String.IsNullOrEmpty(HttpContext.Session.GetString("username")))
            {
                return RedirectToAction("Login", "Auth");
            }

            Book book = await _context.Books.FindAsync(id);

            Payment newPayment = new Payment()
            {
                CreatedDate = DateTime.Now,
                UserId = int.Parse(HttpContext.Session.GetString("id")),
                BookId = book.Id,
                BookPrice = book.Price,
                BookName = book.Title,
                PaymentOver = false,
            };

            _context.Payments.Add(newPayment);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public async Task<IActionResult> SubmitPayment()
        {
            if (String.IsNullOrEmpty(HttpContext.Session.GetString("username")))
            {
                return RedirectToAction("Index", "Home");
            }

            int userId = int.Parse(HttpContext.Session.GetString("id"));
            var payments = from p in _context.Payments
                           where p.UserId == userId && p.PaymentOver == false
                           select p;

            double totalPayment = 0;
            foreach (Payment p in payments)
            {
                totalPayment += p.BookPrice;
            }

            User user = await _context.Users.FindAsync(userId);
            _context.Users.Update(user);

            foreach (Payment p in payments)
            {
                p.PaymentOver = true;
                p.OldBallance = user.AccountBalance;
                p.NewBallance = user.AccountBalance - p.BookPrice;
                user.AccountBalance -= p.BookPrice;
                _context.Payments.Update(p);
            }

            await _context.SaveChangesAsync();

            return RedirectToAction("Basket");
        }

        [HttpPost]
        public async Task<IActionResult> RemovePayment(int id)
        {
            if (String.IsNullOrEmpty(HttpContext.Session.GetString("username")))
            {
                return RedirectToAction("Index", "Home");
            }

            var payment = await _context.Payments.FindAsync(id);
            _context.Payments.Remove(payment);
            await _context.SaveChangesAsync();

            return RedirectToAction("Basket");
        }

        public IActionResult ChangePassword()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ChangePassword(PasswordResetViewModel passwordResetViewModel)
        {
            if (String.IsNullOrEmpty(HttpContext.Session.GetString("username")))
            {
                return RedirectToAction("Index", "Home");
            }

            if (ModelState.IsValid)
            {
                int userId = Int32.Parse(HttpContext.Session.GetString("id"));
                User user = await _context.Users.FindAsync(userId);

                if (passwordResetViewModel.NewPassword != passwordResetViewModel.ConfirmedPassword || !_auth.ValidateUser(user, passwordResetViewModel.Password))
                {
                    ModelState.AddModelError("Password", "Password missmatch");
                    ModelState.AddModelError("NewPassword", "Password missmatch");
                    ModelState.AddModelError("ConfirmedPassword", "Password missmatch");
                    return View("ChangePassword", passwordResetViewModel);
                }

                byte[] passwordHash, passwordSalt;
                _auth.CreatePasswordHash(passwordResetViewModel.NewPassword, out passwordHash, out passwordSalt);

                user.PasswordHash = passwordHash;
                user.PasswordSalt = passwordSalt;

                _context.Update(user);
                await _context.SaveChangesAsync();
                
                return RedirectToAction("Profile");
            }

            return View("ChangePassword", passwordResetViewModel);
        }
    }
}