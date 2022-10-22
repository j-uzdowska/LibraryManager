using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace LibraryManager.Models
{
    public class LibraryEntities:DbContext
    {
        DbSet<Book> Books { get; set; }
        DbSet<Reservation> Reservations { get; set; }
    }
}