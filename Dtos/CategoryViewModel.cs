using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using EKnjiznica.Models;

namespace EKnjiznica.Dtos
{
    public class CategoryViewModel
    {
        public List<Category> Categories { get; set; }

        [Required]
        public string Description { get; set; }
    }
}