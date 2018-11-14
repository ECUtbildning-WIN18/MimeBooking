using System;
using System.Collections.Generic;
using System.Text;

namespace MimeBooking.Domain
{
    class AddClient
    {
        public bool AddNewClient()
        {

            Console.Write("Enter Clients First Name:");
            string FirstName = Console.ReadLine();

            Console.Write("Enter Clients Last Name:");
            string LastName = Console.ReadLine();

            Console.Write("Enter SocialSecurityNumber:");
            string SSN = Console.ReadLine();

            Console.Write("Enter Main Act:");
            string MainAct = Console.ReadLine();
            
            Console.Write("Is this Correct (Y)es/(N)o");
            var consoleKeyInfo = Console.ReadKey();
            if (consoleKeyInfo.Key == ConsoleKey.Y)
            {
                Client NewClient = new Client(FirstName, LastName, SSN, MainAct);
                using (var context = new MimeBookingDBContext())
                {
                    context.Clients.Add(NewClient);
                    context.SaveChanges();
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
