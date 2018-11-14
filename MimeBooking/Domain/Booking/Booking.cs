using System;
using System.Collections.Generic;
using System.Text;

namespace MimeBooking.Domain
{
    class Booking
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public int Preformer { get; set; }
        public int Id { get; set; }

        public Booking() { }

        public Booking(string name, DateTime date, int preformer)
        {
            Name = name;
            Date = date;
            Preformer = preformer;
        }
    }
}
