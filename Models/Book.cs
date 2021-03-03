using System;
using System.ComponentModel.DataAnnotations;

namespace Bookish.Models
{
    public class Book { 
        public int BookId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
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