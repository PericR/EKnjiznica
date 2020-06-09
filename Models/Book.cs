using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EKnjiznica.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }
        
        [Required]
        public string Author { get; set; }

        [Required]
        public double Price { get; set; }

        public string CategoryName { get; set; }

        [Required]
        Category Category { get; set; }
        public int CategoryId { get; set; }

        public ICollection<Payment> Payments { get; set; }
    }
}