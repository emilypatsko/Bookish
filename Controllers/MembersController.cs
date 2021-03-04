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
    public class MembersController : Controller
    {
        private readonly ILogger<MembersController> _logger;

        public MembersController(ILogger<MembersController> logger)
        {
            _logger = logger;
        }
    
        public IActionResult Index()
        {
            MemberCatalogueViewModel MemberList = new MemberCatalogueViewModel();
            using (var LibraryCtx = new BookishContext())
            {
                MemberList.MemberCatalogue = LibraryCtx.Members.Take(10).ToList();
            }

            return View(MemberList);
        }
        
         public IActionResult AddMember()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddMember(Member newmember)
        {
            using (var LibraryCtx = new BookishContext())
            {
                LibraryCtx.Members.Add(newmember);
                LibraryCtx.SaveChanges();
            }
            return RedirectToAction("AddMember");
        }

        public IActionResult Delete(int? id, bool? saveChangesError=false)
        {
            var MemberId = id;
            var LibraryCtx = new BookishContext();
            Member member = LibraryCtx.Members.Find(MemberId);
            if (member == null)
            {
                return RedirectToAction("Error");
            }
            return View(member);
        } 

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var MemberId = id;
            var LibraryCtx = new BookishContext();
            Member member = LibraryCtx.Members.Find(MemberId);
            
            LibraryCtx.Members.Remove(member);
            List<Checkout> checkouts = LibraryCtx.Checkouts.Where(m => m.Member == member).ToList();
            LibraryCtx.Checkouts.RemoveRange(checkouts);
     
            LibraryCtx.SaveChanges();            
            return RedirectToAction("Index");            
        } 


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}