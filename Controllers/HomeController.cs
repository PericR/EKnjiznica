using System;
using Microsoft.AspNetCore.Http;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EKnjiznica.Models;
using EKnjiznica.Data;
using EKnjiznica.Dtos;

namespace EKnjiznica.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DataContext _context;

        public HomeController(ILogger<HomeController> logger, DataContext context)
        {
            _context = context;
            _logger = logger;
        }

        public IActionResult Index(string searchCategory, string searchTitle, string searchAuthor)
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

        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
