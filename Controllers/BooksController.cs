using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Data;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Bookish.Models;
using Bookish.Data;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Bookish.Controllers
{
    public class BooksController : Controller
    {
        private readonly ILogger<BooksController> _logger;

        public BooksController(ILogger<BooksController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(string sortOrder, string searchString)
        {
            ViewBag.TitleSortParm = sortOrder == "Title" ? "Title_desc" : "Title";
            ViewBag.YearSortParm = sortOrder == "Year" ? "Year_desc" : "Year";
            var LibraryCtx = new BookishContext();
            var Books = from b in LibraryCtx.Books
                        select b;

            if (!String.IsNullOrEmpty(searchString))
            {
                Books = Books.Where(b => b.Title.Contains(searchString)
                                       || b.Author.Contains(searchString)
                                       || b.Year.ToString().Contains(searchString)
                                       );
            }

            switch (sortOrder)
            {
                case "Title":
                    Books = Books.OrderBy(b => b.Title);
                    break;
                case "Title_desc":
                    Books = Books.OrderByDescending(b => b.Title);
                    break;
                case "Year":
                    Books = Books.OrderBy(b => b.Year);
                    break;
                case "Year_desc":
                    Books = Books.OrderByDescending(b => b.Year);
                    break;
                default:
                    Books = Books.OrderBy(b => b.BookId);
                    break;
            }

            BookCatalogueViewModel BookList = new BookCatalogueViewModel();
            BookList.BookCatalogue = Books.ToList();
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

        public IActionResult Edit(int? id) {
            var BookId = id;
            var LibraryCtx = new BookishContext();
            Book book = LibraryCtx.Books.Find(BookId);
            if (book == null)
            {
                return RedirectToAction("Error");
            }
            return View(book);
        }

        [HttpPost]
        public IActionResult Edit(Book book) {            
            using (var LibraryCtx = new BookishContext()) 
            {
                var BookId = book.BookId;
                Book bookToUpdate = LibraryCtx.Books.Find(BookId);
                bookToUpdate.Title = book.Title;
                bookToUpdate.Author = book.Author;
                bookToUpdate.Year = book.Year;
                LibraryCtx.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        public IActionResult AddCopy(int? id)
        {
            var BookId = id;
            var LibraryCtx = new BookishContext();
            Book book = LibraryCtx.Books.Find(BookId);
            if (book == null)
            {
                return RedirectToAction("Error");
            }
            return View(book);
        }
        
        [HttpPost]
        public IActionResult AddCopy(int id, int NumOfCopies)
        {
            var BookId = id;
            using (var LibraryCtx = new BookishContext())
            {                
                Book book = LibraryCtx.Books.Find(BookId);
                if (book == null)
                {
                    return RedirectToAction("Error");
                }

                for (var i = 0; i < NumOfCopies; i++)
                {
                    Copy NewCopy = new Copy();
                    NewCopy.Book = book;
                    NewCopy.CheckedOut = false;
                    LibraryCtx.Copies.Add(NewCopy);
                }

                LibraryCtx.SaveChanges();
            }
            return RedirectToAction("Details", new { id = BookId});          
        }


        public IActionResult Checkout(int? id) {
            // var BookId = id;
            // var LibraryCtx = new BookishContext();
            // Book book = LibraryCtx.Books.Find(BookId);
            // if (book == null)
            // {
            //     return RedirectToAction("Error");
            // }
            // List<Copy> copies = LibraryCtx.Copies.Where(b => b.Book == book).ToList();
            // List<Checkout> checkouts=new List<Checkout>();
            // CheckoutCatalogueViewModel CheckoutList = new CheckoutCatalogueViewModel();
           
            // foreach (var copy in copies)
            // {
            //     foreach (var check in checkouts)
            //     {
            //         if (check.Copy==copy)
            //         {
            //             checkouts.Add(check);
            //         }
            //     }
            // }
            // CheckoutList.CheckoutCatalogue = checkouts.ToList(); 
            // return View(CheckoutList);

            var CopyId = id;
            var LibraryCtx = new BookishContext();
            Copy copy = LibraryCtx.Copies.Find(CopyId);
            if (copy == null)
            {
                return RedirectToAction("Error");
            }
            
            CheckoutCatalogueViewModel CheckoutList = new CheckoutCatalogueViewModel();
            var checkouts = LibraryCtx.Checkouts.Where(c => c.Copy.CopyId == CopyId)
                                                   .Include(c => c.Copy)
                                                   .Include(c => c.Copy.Book)
                                                   .Include(c => c.Member);
                    
            CheckoutList.CheckoutCatalogue = checkouts.ToList(); 
            return View(CheckoutList);
        }

        public IActionResult Details(int? id) {
            var BookId = id;
            var LibraryCtx = new BookishContext();
            Book book = LibraryCtx.Books.Find(BookId);
            if (book == null)
            {
                return RedirectToAction("Error");
            }
            List<Copy> copies = LibraryCtx.Copies.Where(b => b.Book == book).ToList();
            
            CopyCatalogueViewModel CopyList = new CopyCatalogueViewModel();
           
            CopyList.CopyCatalogue = copies.ToList(); 
            return View(CopyList);
        }

        public IActionResult CheckoutCopy(int? id) {
            var CopyId = id;
            Copy CopyToCheckout = new Copy();
            using (var LibraryCtx = new BookishContext())
            {
                CopyToCheckout = LibraryCtx.Copies.Find(CopyId);
                return View(CopyToCheckout);
            }            
        }
        
        [HttpPost]
        public IActionResult CheckoutCopy(int copyid, int memberid) {

            var CopyId = copyid;
            var MemberId = memberid;
            Copy CopyToCheckout = new Copy();
            Member MemberToCheckout = new Member();            

            using (var LibraryCtx = new BookishContext()) {
                // change this copy to being checked out
                CopyToCheckout = LibraryCtx.Copies.Find(CopyId);
                CopyToCheckout.CheckedOut = true;

                MemberToCheckout = LibraryCtx.Members.Find(MemberId);
                Checkout NewCheckout = new Checkout();
                NewCheckout.Copy = CopyToCheckout;
                NewCheckout.Member = MemberToCheckout;
                NewCheckout.CheckoutDate = DateTime.Now;
                NewCheckout.DueDate = DateTime.Now.AddDays(14);
                NewCheckout.Returned = false;

                LibraryCtx.Checkouts.Add(NewCheckout);
                LibraryCtx.SaveChanges();       

                // want to get the bookID of the copy, something like Copy.Book.BookId
                var BookToDisplay = LibraryCtx.Copies.Where(c => c.CopyId == copyid).Include(c => c.Book).First();   
                return RedirectToAction("Details", new { id = BookToDisplay.Book.BookId});     
            }                    
        }

        public IActionResult Delete(int? id, bool? saveChangesError=false)
        {
            var BookId = id;
            var LibraryCtx = new BookishContext();
            Book book = LibraryCtx.Books.Find(BookId);
            if (book == null)
            {
                return RedirectToAction("Error");
            }
            return View(book);
        } 

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var BookId = id;
            using (var LibraryCtx = new BookishContext())
            {
                Book book = LibraryCtx.Books.Find(BookId);
                LibraryCtx.Books.Remove(book);
                List<Copy> copies = LibraryCtx.Copies.Where(b => b.Book == book).ToList();
                LibraryCtx.Copies.RemoveRange(copies);
                foreach(var c in copies)
                {
                    LibraryCtx.Checkouts.RemoveRange(LibraryCtx.Checkouts.Where(x => x.Copy == c).ToList());
                }
        
                LibraryCtx.SaveChanges(); 
            }           
            return RedirectToAction("Index");            
        } 

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
