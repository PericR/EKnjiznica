using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using EKnjiznica.Models;

namespace EKnjiznica.Dtos
{
    public class EditBookViewModel
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public int CategoryId { get; set; }
        public List<Category> Categories { get; set; }
    }
}