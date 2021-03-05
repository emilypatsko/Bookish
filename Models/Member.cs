using System;
using System.ComponentModel.DataAnnotations;

namespace Bookish.Models
{
    public class Member { 
        public int MemberId { get; set; }
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string ContactNumber { get; set; }

    }
}