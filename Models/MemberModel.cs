using System;

namespace Bookish.Models
{
    public class MemberModel { 
        public int MemberID { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string ContactNumber { get; set; }

        public MemberModel(int id, string firstname, string surname, string email, string contactnumber) {
            MemberID = id;
            FirstName = firstname;
            Surname = surname;
            Email = email;
            ContactNumber=contactnumber;
        }
    }
}