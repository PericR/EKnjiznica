using System.Collections.Generic;
using EKnjiznica.Models;

namespace EKnjiznica.Dtos
{
    public class BasketViewModel
    {
        public List<Payment> Payments { get; set; }
        
        public double TotalPrice { get; set; }
        public double CurrentBallance { get; set; }
        public double NewBallance { get; set; }
        public string UserName { get; set; }
    }
}