using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Bookish.Models;
using Bookish.Data;

namespace Bookish.Controllers
{
    public class BooksController : Controller
    {
        private readonly ILogger<BooksController> _logger;

        public BooksController(ILogger<BooksController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            BookCatalogueViewModel BookList = new BookCatalogueViewModel();
            using (var LibraryCtx = new BookishContext())
            {
                BookList.BookCatalogue = LibraryCtx.Books.Take(10).ToList();
            }

            return View(BookList);
        }

        public IActionResult AddBook()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddBook(Book newbook)
        {
            using (var LibraryCtx = new BookishContext())
            {
                bool BookExists = LibraryCtx.Books.Any(b => b.Title == newbook.Title && b.Author == newbook.Author && b.Year == newbook.Year);

                // if book is not already in catalogue, add it
                if (!BookExists)
                {
                    LibraryCtx.Books.Add(newbook);
                    Copy NewCopy = new Copy();
                    NewCopy.Book = newbook;
                    NewCopy.CheckedOut = false;
                    LibraryCtx.Copies.Add(NewCopy);
                }       
                else 
                {
                    Copy NewCopy = new Copy();
                    Book SameBook = LibraryCtx.Books.Where(b => b.Title == newbook.Title && b.Author == newbook.Author && b.Year == newbook.Year).ToList().First();
                    NewCopy.Book = SameBook;
                    // NewCopy.Book = the book already in the catalogue                    
                    NewCopy.CheckedOut = false;
                    LibraryCtx.Copies.Add(NewCopy);
                }

                LibraryCtx.SaveChanges();
            }
            return RedirectToAction("AddBook");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
