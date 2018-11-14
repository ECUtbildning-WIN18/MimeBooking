using MimeBooking.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace MimeBooking.Views
{
    class CreateBookingView
    {
         bool BookingAdded = false;

        public void Display()
        {
            AddBooking Booking = new AddBooking();
            while (BookingAdded == false)
            {
                Console.Clear();
                BookingAdded = Booking.AddNewBooking();
            }
        }
    }
}
