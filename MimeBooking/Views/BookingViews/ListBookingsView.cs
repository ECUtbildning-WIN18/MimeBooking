using MimeBooking.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace MimeBooking.Views
{
    class ListBookingsView
    {
        public void Display()
        {
            ListBookings Bookings = new ListBookings();
            
            Console.Clear();
            Bookings.Display();
        }
    }
}
