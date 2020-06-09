using System.ComponentModel.DataAnnotations;

namespace EKnjiznica.Dtos
{
    public class UserForLogin
    {
        [Required]
        public string Username { get; set; }

        [Required, StringLength(16, MinimumLength = 8)]
        public string Password { get; set; }

    }
}