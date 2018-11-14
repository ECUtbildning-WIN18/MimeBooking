using System;
using System.Collections.Generic;
using System.Text;

namespace MimeBooking.Domain
{
    class AddBooking
    {
        public bool AddNewBooking()
        {

            Console.Write("Enter Event Name:");
            string Name = Console.ReadLine();

            Console.Write("Enter Event Date:");
            DateTime Date = Convert.ToDateTime(Console.ReadLine());

            Console.Write("Enter Preformers FirstName(Client):");
            string Preformer = Console.ReadLine();
            
            Console.Write("Is this Correct (Y)es/(N)o");
            var consoleKeyInfo = Console.ReadKey();
            if (consoleKeyInfo.Key == ConsoleKey.Y)
            {
                // Check if Preformer is in database
                // New Client = Client From Database
                // Add newClient to NewBooking
                // Legit?
                using (var context = new MimeBookingDBContext())
                {
                    var ClientList = new LoadClients();
                    var Clients = ClientList.GetClients();
                    foreach (Client client in Clients)
                    {
                        if (Preformer == client.FirstName)//This can be improved but im busy fixing other stuff
                        {
                            Booking NewBooking = new Booking(Name, Date, client.Id);
                            context.Bookings.Add(NewBooking);
                            context.SaveChanges();
                        }
                    }
                    
                }
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
