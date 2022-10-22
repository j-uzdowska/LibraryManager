using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryManager.Models
{
    public class Reservation
    {
        public int ReservationId { get; set; }
        public string UserId { get; set; }
        public DateTime ReservationDate { get; set; }
        public int BookId { get; set; }
    }
}