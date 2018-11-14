using System;
using System.Collections.Generic;
using System.Text;

namespace MimeBooking.Domain
{
    class Client
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SocialSecurityNumber { get; set; }
        public string MainAct { get; set; }
        public int Id { get; set; }

        public Client() { }

        public Client(string firstName, string lastName, string socialSecurityNumber, string mainAct)
        {
            FirstName = firstName;
            LastName = lastName;
            SocialSecurityNumber = socialSecurityNumber;
            MainAct = mainAct;
        }
    }
}
