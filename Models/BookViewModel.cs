using System;

namespace Bookish.Models
{
    public class BookViewModel { 
        public int ID { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public string Author { get; set; }

        public BookViewModel(int id, string title, int year, string author) {
            ID = id;
            Title = title;
            Year = year;
            Author = author;
        }

    }
}