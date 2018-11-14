using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MimeBooking.Domain
{
    class ListBookings
    {
        public void Display()
        {
            using (var context = new MimeBookingDBContext())// context
            {
                var BookinsList = context.Bookings.ToList();
                var ClientList = new LoadClients();
                ClientList.GetClients();
                Console.WriteLine("Event\tDate\t\t\tPreformer");
                Console.WriteLine("----------------------------------------------------");
                foreach (Booking booking in BookinsList)
                {
                    var client = GetClientbyId(booking.Preformer);
                    Console.WriteLine($"{ booking.Name}\t{ booking.Date}\t{client.FirstName}");
                }
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine("(D)elete (Esc) Return to Main Menu");
                var input = Console.ReadKey();
                if (input.Key == ConsoleKey.D) {
                    Console.WriteLine("Enter Event Name:");
                    string EventName = Console.ReadLine();
                    foreach (Booking booking in BookinsList)
                    {
                        if (EventName == booking.Name)//This can be improved but im busy fixing other stuff
                        {
                            context.Attach(booking);
                            context.Bookings.Remove(booking);
                            context.SaveChanges();
                        }
                    }
                        
                    
                }

            }
        }

        private Client GetClientbyId(int id)
        {
            using (var context = new MimeBookingDBContext())// context
            {
               var client = context.Clients.First(x => x.Id == id);
                return client;
            }
        }
    }
}
