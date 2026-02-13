using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public bool IsContacted { get; set; } = false;

        // what a contact can do (print to string)
        public override string? ToString()
        {
            return $"Name: {FirstName} {LastName} Phone: {PhoneNumber} Email: {Email} - Contacted: {IsContacted}";
        }

    }
}
