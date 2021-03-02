using System;

namespace Bookish.Models
{
    public class Copy { 
        public int CopyId { get; set; }
        public Book Book { get; set; }
        public bool CheckedOut { get; set; }

        // public CopyModel(int copyid, int bookid, bool checkedout) {
        //     CopyID = copyid;
        //     BookID = bookid;
        //     CheckedOut = checkedout;
        // }
        // public CopyModel(){
            
        // }
    }
}