using System;
using System.Collections.Generic;

namespace Bookish.Models {
    public class BookCatalogueViewModel {
        public List<Book> BookCatalogue { get; set; }

        public BookCatalogueViewModel() {
            BookCatalogue = new List<Book>();
        }

        public BookCatalogueViewModel(List<Book> books) {
            BookCatalogue = books;
        }
    }
}