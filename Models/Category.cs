using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EKnjiznica.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        public string Description { get; set; }
        public bool IsDisabled { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}