using System;

namespace Bookish.Models
{
    public class Checkout { 
        public int CheckoutId { get; set; }
        public Copy Copy  { get; set; }
        public Member Member { get; set; }
        public DateTime CheckoutDate { get; set; }
        public DateTime DueDate { get; set; }
        public Boolean Returned { get; set; }

    }
}