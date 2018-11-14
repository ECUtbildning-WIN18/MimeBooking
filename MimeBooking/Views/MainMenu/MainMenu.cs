using System;
using System.Collections.Generic;
using System.Text;

namespace MimeBooking.Views
{
    class MainMenu
    {
        public void Display()
        {
            Console.Title = "The Menu";
            Console.ForegroundColor = ConsoleColor.Green;
            bool LoopisFinished = false;
            while (LoopisFinished == false) // Stop loop to go back to Main
            {
                Console.Clear(); 
                Console.WriteLine("== Stuff Menu ==");
                Console.WriteLine("\n1.Enlist new client" +
                                    "\n2.Create new booking" +
                                    "\n3.List bookings" +
                                    "\n4.Exit");
                Console.Write("\nSelect Action:");
                var input = Console.ReadKey();

                switch (input.Key)
                {
                    case ConsoleKey.D1: // Enlist new Client
                        var NewClient = new AddClientView();
                        NewClient.Display();
                        break;

                    case ConsoleKey.D2: // Create New Booking
                        var NewBooking = new CreateBookingView();
                        NewBooking.Display();
                        break;
                    case ConsoleKey.D3: // Listu Bookingu
                        var ListBooking = new ListBookingsView();
                        ListBooking.Display();
                        break;
                    case ConsoleKey.D4: // RIP THE DREAMS
                        LoopisFinished = true;
                        break;

                    default:
                        Console.WriteLine("Selection Error");
                        break;
                }
            }
        }
    }
}
