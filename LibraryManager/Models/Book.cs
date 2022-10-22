using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryManager.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string PublishDate { get; set; }
        public string Description { get; set; }
        public List<Reservation> Reservations { get; set; }
    }
}