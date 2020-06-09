using System.Collections.Generic;
using EKnjiznica.Models;

namespace EKnjiznica.Dtos
{
    public class ProfileViewModel
    {
        public List<Book> Books { get; set; }
        public List<Payment> Payments { get; set; }
        public List<Transaction> Transactions { get; set; }

        public int UserId { get; set; }
        public double AddedCredit { get; set; }
        public string Username { get; set; }
        public string FullName { get; set; }
        public double AccountBalance { get; set; }
        public string Email { get; set; }
    }
}