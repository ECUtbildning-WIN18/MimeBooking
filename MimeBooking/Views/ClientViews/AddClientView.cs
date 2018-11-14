using MimeBooking.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace MimeBooking.Views
{
    class AddClientView
    {

            bool ClientAdded = false;

        public void Display()
        {
            AddClient System = new AddClient();
            while (ClientAdded == false)
            {
                Console.Clear();
               ClientAdded = System.AddNewClient();
            }
        }


        }
    }

