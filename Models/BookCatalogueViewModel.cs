using System;
using System.Collections.Generic;

namespace Bookish.Models {
    public class BookCatalogueViewModel {
        public List<BookModel> BookCatalogue { get; set; }

        public BookCatalogueViewModel() {
            BookCatalogue = new List<BookModel>();
        }

        public BookCatalogueViewModel(List<BookModel> books) {
            BookCatalogue = books;
        }
    }
}