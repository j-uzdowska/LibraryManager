using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LibraryManager.Models;
using RestSharp;

namespace LibraryManager.Controllers
{
   
    public class HomeController : Controller
    {
        LibraryEntities db = new LibraryEntities();
        public ActionResult Index()
        {
            int count = db.Books.Select(a => a).Count();
            Random r = new Random();
            Book randomBook = db.Books.Find(r.Next(1,count+1));

            

            return View(randomBook);
        }

        

       
    }
}