using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactApp
{
    public class Contact
    {
        // what describes a contact (name, email, etc)
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }

        // construct a new contact
        public Contact()
        {
            
        }


        // what a contact can do (print to string)

    }
}
