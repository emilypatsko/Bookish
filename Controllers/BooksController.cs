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
                var NewBook = new Book();
                NewBook.Title = newbook.Title;
                NewBook.Author = newbook.Author;
                NewBook.Year = newbook.Year;

                LibraryCtx.Books.Add(NewBook);
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
