using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using EKnjiznica.Models;

namespace EKnjiznica.Dtos
{
    public class BookViewModel
    {
        public List<Book> Books { get; set; }

        public List<Category> Categories { get; set; }

        [Required]
        public string Title { get; set; }
        
        [Required]
        public string Author { get; set; }

        public int CategoryId { get; set; }
        
        [Required]
        public double Price { get; set; }
        public string SearchCategory { get; set; }
        public string SearchTitle { get; set; }
        public string SearchAuthor { get; set; }
    }
}