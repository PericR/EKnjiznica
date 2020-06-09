using System.ComponentModel.DataAnnotations;

namespace EKnjiznica.Dtos
{
    public class PasswordResetViewModel
    {
        
        [Required, StringLength(16, MinimumLength = 8)]
        public string Password { get; set; }

        [Required, StringLength(16, MinimumLength = 8)]
        public string ConfirmedPassword { get; set; }

        [Required, StringLength(16, MinimumLength = 8)]
        public string NewPassword { get; set; }
    }
}