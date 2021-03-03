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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}