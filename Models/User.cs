using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EKnjiznica.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Username { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        
        public string FirstName { get; set; }
        
        public string LastName { get; set; }
         public double AccountBalance { get; set; }
         public bool IsAdmin { get; set; }

         public string Email { get; set; }

         public ICollection<Payment> Payments { get; set; }

        [InverseProperty("Client")]
         public ICollection<Transaction> TransactionsClient { get; set; }


        [InverseProperty("Admin")]
         public ICollection<Transaction> TransactionsAdmin { get; set; }
    }
}