using System.ComponentModel.DataAnnotations;

namespace EKnjiznica.Dtos
{
    public class UserForRegister
    {
        [Required]
        public string Username { get; set; }

        [Required, StringLength(16, MinimumLength = 8)]
        public string Password { get; set; }

        [Required, StringLength(16, MinimumLength = 8)]
        public string ConfirmedPassword { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }
    }
}