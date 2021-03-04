using System;

namespace Bookish.Models
{
    public class Copy { 
        public int CopyId { get; set; }
        public Book Book { get; set; }
        public bool CheckedOut { get; set; }
    }
}