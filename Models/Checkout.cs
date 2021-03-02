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

        // public CheckoutModel(int checkoutid, int copyid, int memberid, DateTime checkoutdate, DateTime duedate, Boolean returned) 
        // {
        //     CheckoutID = checkoutid;
        //     CopyID = copyid;
        //     MemberID = memberid;
        //     CheckoutDate = checkoutdate; 
        //     DueDate = duedate; 
        //     Returned = returned; 
        // }

        // public CheckoutModel() {

        // }
    }
}