using System;


namespace Bookish.Models
{
    public class Book { 
        public int BookId { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public string Author { get; set; }

        // public BookModel(int id, string title, int year, string author) {
        //     BookID = id;
        //     Title = title;
        //     Year = year;
        //     Author = author;
        // }
        // public BookModel() {
            
        // }
    }
}