using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MimeBooking.Domain
{
    class LoadClients
    {
        public IList<Client> GetClients()// ENTETY FRAMEWORK 
        {
            using (var context = new MimeBookingDBContext())// context
            {
                return context.Clients.ToList();
            }
        }
    }
}
