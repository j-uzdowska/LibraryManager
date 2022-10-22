using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LibraryManager.Models;

namespace LibraryManager.Controllers
{
    public class LibraryController : Controller
    {
        LibraryEntities db = new LibraryEntities();

        // GET: Library
        public ActionResult Index()
        {
            var books = db.Books.ToList();
            return View(books);
        }

        public ActionResult Details(int id)
        {
            var book = db.Books.Find(id);
            return View(book);
        }

        [Authorize]
        public ActionResult Reserve(int id)
        {
            var book = db.Books.Find(id);
            Reservation r = new Reservation { ReservationDate = DateTime.Now, BookId = id, UserId = User.Identity.Name };
            db.Reservations.Add(r);
            db.SaveChanges();
            ViewBag.ReservedBook = book.Name;
            return View();
        }

        [Authorize]
        public ActionResult ReservationHistory(int id)
        {
            var reservations = db.Reservations.Select(r => r).Where(r=>r.BookId==id);
            return View(reservations);
        }
    }
}