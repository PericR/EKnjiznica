using System;

namespace EKnjiznica.Models
{
    public class Payment
    {
        public int Id { get; set; }

        public DateTime CreatedDate { get; set; }

        public double OldBallance { get; set; }
        public double NewBallance { get; set; }

        public double BookPrice { get; set; }

        public bool PaymentOver { get; set; }

        public User User { get; set; }
        public int UserId { get; set; }

        public Book Book { get; set; }
        public int BookId { get; set; }
        public string BookName { get; set; } 
    }
}