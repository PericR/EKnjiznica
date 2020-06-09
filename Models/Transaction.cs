using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace EKnjiznica.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }

        public double OldBallance { get; set; }
        public double NewBallance { get; set; }

        public double Value { get; set; }

        public int ClientId { get; set; }
        public int AdminId { get; set; }

        [ForeignKey("ClientId")]
        public virtual User Client { get; set; }
    
        [ForeignKey("AdminId")]        
        public virtual User Admin { get; set; }
    }
}