using System.Collections.Generic;
using EKnjiznica.Models;

namespace EKnjiznica.Dtos
{
    public class PaymentViewModel
    {
        public List<Payment> Payments { get; set; }

        public string SearchUser { get; set; }
        public string SearchTitle { get; set; }
        public string SearchAuthor { get; set; }
    }
}