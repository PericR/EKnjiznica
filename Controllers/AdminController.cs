using System.Threading.Tasks;
using System.Linq;
using EKnjiznica.Data;
using EKnjiznica.Dtos;
using EKnjiznica.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace EKnjiznica.Controllers
{
    public class AdminController : Controller
    {
        private readonly DataContext _context;
        private readonly IAuthRepository _auth;
        public AdminController(DataContext context, IAuthRepository auth)
        {
            _auth = auth;
            _context = context;
        }

        public IActionResult AddAdmin()
        {
            if (HttpContext.Session.GetString("role") != "admin")
            {
                return RedirectToAction("Index", "Home");
            }

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddAdmin([Bind("Username, Password, FirstName, LastName, Email")] UserForRegister userForRegister)
        {
            if (HttpContext.Session.GetString("role") != "admin")
            {
                return RedirectToAction("Index", "Home");
            }

            if (ModelState.IsValid)
            {
                if (_auth.CheckUsername(userForRegister.Username))
                {
                    ModelState.AddModelError("Username", "Username taken");
                    return View(userForRegister);
                }

                User newAdmin = _auth.CreateNewUser(userForRegister);
                newAdmin.IsAdmin = true;

                _context.Users.Add(newAdmin);
                await _context.SaveChangesAsync();

                TempData["Success"] = "Added Successfully";
                return RedirectToAction("AddAdmin");
            }

            return View(userForRegister);
        }

        public IActionResult ManageAdmins()
        {
            if (HttpContext.Session.GetString("role") != "admin")
            {
                return RedirectToAction("Index", "Home");
            }

            var admins = from a in _context.Users
                         where a.IsAdmin == true
                         select a;
            User[] adminsArray = admins.ToArray();

            return View(adminsArray);
        }

        public IActionResult ManageUsers()
        {
            if (HttpContext.Session.GetString("role") != "admin")
            {
                return RedirectToAction("Index", "Home");
            }

            var users = from a in _context.Users
                        where a.IsAdmin == false
                        select a;
            User[] usersArray = users.ToArray();

            return View(usersArray);
        }

        public async Task<IActionResult> ManageUser(int id)
        {
            if (HttpContext.Session.GetString("role") != "admin")
            {
                return RedirectToAction("Index", "Home");
            }

            User user = await _context.Users.FindAsync();

            return View(user);
        }

        [HttpPost]
        public async Task<IActionResult> RemoveUser(int id)
        {
            if (HttpContext.Session.GetString("role") != "admin")
            {
                return RedirectToAction("Index", "Home");
            }

            var user = await _context.Users.FindAsync(id);
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public async Task<IActionResult> ResetUserPassword(int id)
        {
            if (HttpContext.Session.GetString("role") != "admin")
            {
                return RedirectToAction("Index", "Home");
            }

            User user = await _context.Users.FindAsync(id);
            byte[] passwordHash, passwordSalt;
            _auth.CreatePasswordHash("12345678", out passwordHash, out passwordSalt);

            user.PasswordHash = passwordHash;
            user.PasswordSalt = passwordSalt;

            _context.Update(user);
            await _context.SaveChangesAsync();

            return RedirectToAction("ManageAdmins");
        }

        public IActionResult ManageCategories()
        {
            if (HttpContext.Session.GetString("role") != "admin")
            {
                return RedirectToAction("Index", "Home");
            }

            var categories = from c in _context.Categories
                             select c;
            CategoryViewModel categoryViewModel = new CategoryViewModel();
            categoryViewModel.Categories = categories.ToList();

            return View(categoryViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> AddCategory(CategoryViewModel categoryViewModel)
        {
            if (HttpContext.Session.GetString("role") != "admin")
            {
                return RedirectToAction("Index", "Home");
            }

            if (ModelState.IsValid)
            {
                Category category = new Category();
                category.Description = categoryViewModel.Description;
                category.IsDisabled = false;

                _context.Categories.Add(category);
                await _context.SaveChangesAsync();
            }


            return RedirectToAction("ManageCategories");
        }

        [HttpPost]
        public async Task<IActionResult> DisableCathegory(int id)
        {
            if (HttpContext.Session.GetString("role") != "admin")
            {
                return RedirectToAction("Index", "Home");
            }

            var category = await _context.Categories.FindAsync(id);
            category.IsDisabled = true;

            _context.Categories.Update(category);
            await _context.SaveChangesAsync();

            return RedirectToAction("ManageCategories");
        }

        [HttpPost]
        public async Task<IActionResult> EnableCathegory(int id)
        {
            if (HttpContext.Session.GetString("role") != "admin")
            {
                return RedirectToAction("Index", "Home");
            }

            var category = await _context.Categories.FindAsync(id);
            category.IsDisabled = false;

            _context.Categories.Update(category);
            await _context.SaveChangesAsync();

            return RedirectToAction("ManageCategories");
        }

        public IActionResult ManageBooks(string searchCategory, string searchTitle, string searchAuthor)
        {
            var books = from b in _context.Books
                        select b;
            var categories = from c in _context.Categories
                             where c.IsDisabled == false
                             select c;

            if (!String.IsNullOrEmpty(searchAuthor))
            {
                books = books.Where(b => b.Author.ToLower().Contains(searchAuthor.ToLower()));
            }

            if (!String.IsNullOrEmpty(searchTitle))
            {
                books = books.Where(b => b.Title.ToLower().Contains(searchTitle.ToLower()));
            }

            if (!String.IsNullOrEmpty(searchCategory))
            {
                books = books.Where(b => b.CategoryName.ToLower().Contains(searchCategory.ToLower()));
            }

            BookViewModel bookViewModel = new BookViewModel();
            bookViewModel.Books = books.ToList();
            bookViewModel.Categories = categories.ToList();

            return View(bookViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> AddBook(BookViewModel bookViewModel)
        {
            if (HttpContext.Session.GetString("role") != "admin")
            {
                return RedirectToAction("Index", "Home");
            }

            if (ModelState.IsValid)
            {
                Category category = await _context.Categories.FindAsync(bookViewModel.CategoryId);

                Book newBook = new Book();
                newBook.Title = bookViewModel.Title;
                newBook.Author = bookViewModel.Author;
                newBook.CategoryId = bookViewModel.CategoryId;
                newBook.CategoryName = category.Description;
                newBook.Price = bookViewModel.Price;

                _context.Books.Add(newBook);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction("ManageBooks");
        }

        public async Task<IActionResult> EditBook(int id)
        {
            if (HttpContext.Session.GetString("role") != "admin")
            {
                return RedirectToAction("Index", "Home");
            }
            var categories = from c in _context.Categories
                             where c.IsDisabled == false
                             select c;
            Book book = await _context.Books.FindAsync(id);

            EditBookViewModel editBookViewModel = new EditBookViewModel();
            editBookViewModel.Id = book.Id;
            editBookViewModel.Title = book.Title;
            editBookViewModel.Author = book.Author;
            editBookViewModel.Price = book.Price;
            editBookViewModel.CategoryId = book.CategoryId;
            editBookViewModel.Categories = categories.ToList();

            return View(editBookViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> EditBook(EditBookViewModel editBookViewModel)
        {
            if (HttpContext.Session.GetString("role") != "admin")
            {
                return RedirectToAction("Index", "Home");
            }

            if (ModelState.IsValid)
            {
                Category category = await _context.Categories.FindAsync(editBookViewModel.CategoryId);

                Book book = new Book()
                {
                    Id = editBookViewModel.Id,
                    Title = editBookViewModel.Title,
                    Author = editBookViewModel.Author,
                    Price = editBookViewModel.Price,
                    CategoryId = editBookViewModel.CategoryId,
                    CategoryName = category.Description
                };


                _context.Books.Update(book);
                await _context.SaveChangesAsync();

                return RedirectToAction("ManageBooks");
            }

            var categories = from c in _context.Categories
                             where c.IsDisabled == false
                             select c;
            editBookViewModel.Categories = categories.ToList();

            return View(editBookViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteBook(int id)
        {
            if (HttpContext.Session.GetString("role") != "admin")
            {
                return RedirectToAction("Index", "Home");
            }

            var book = await _context.Books.FindAsync(id);
            _context.Books.Remove(book);
            await _context.SaveChangesAsync();

            return RedirectToAction("ManageBooks");
        }

        public async Task<IActionResult> UserProfile(int id)
        {
            if (HttpContext.Session.GetString("role") != "admin")
            {
                return RedirectToAction("Index", "Home");
            }

            int userId = id;
            User user = await _context.Users.FindAsync(userId);
            var payments = from p in _context.Payments
                           where p.UserId == userId && p.PaymentOver == true
                           select p;
            var transactions = from t in _context.Transactions
                               where t.ClientId == userId
                               select t;

            ProfileViewModel profileViewModel = new ProfileViewModel
            {
                UserId = userId,
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
    
        [HttpPost]
        public async Task<IActionResult> AddCredit(int id, ProfileViewModel profileViewModel)
        {
            if (HttpContext.Session.GetString("role") != "admin")
            {
                return RedirectToAction("Index", "Home");
            }

            User user = await _context.Users.FindAsync(id);
            Transaction transaction = new Transaction
            {
                CreatedDate = DateTime.Now,
                OldBallance = user.AccountBalance,
                NewBallance = user.AccountBalance + profileViewModel.AddedCredit,
                Value = profileViewModel.AddedCredit,
                ClientId = user.Id,
                AdminId = Int32.Parse(HttpContext.Session.GetString("id")),

            };

            if(profileViewModel.AddedCredit > 0)
            {
                user.AccountBalance += profileViewModel.AddedCredit;
                _context.Users.Update(user);
                _context.Transactions.Add(transaction);

                await _context.SaveChangesAsync();
            }

            return RedirectToAction("UserProfile", new {id = id});
        }
    }
}