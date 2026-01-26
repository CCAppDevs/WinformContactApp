

using System.Diagnostics;

namespace ContactApp
{
    public partial class ContactForm : Form
    {
        public List<Contact> Contacts { get; set; }

        public ContactForm()
        {
            InitializeComponent();
            Contacts = new List<Contact>();

            Contacts.Add(new Contact
            {
                FirstName = "Jesse",
                LastName = "Harlan",
                PhoneNumber = "3605551212",
                Email = "jesse.harlan@centralia.edu"
            });

            Contacts.Add(new Contact
            {
                FirstName = "Sarah",
                LastName = "Harlan",
                PhoneNumber = "3605551213",
                Email = "sarah.harlan@email.com"
            });
            AddContact("Ashton", "Harlan", null, "ashton@email.com");
            AddContact(new Contact { FirstName = "Ashton", LastName = "Harlan", Email = "ashton@email.com" });
        }

        public void AddContact(
            string first,
            string last,
            string? phone = null,
            string? email = null
            )
        {
            Contacts.Add(new Contact
            {
                FirstName = first,
                LastName = last,
                PhoneNumber = phone,
                Email = email
            });
        }

        public void AddContact(Contact contact)
        {
            Contacts.Add(contact);
        }

        private void ContactForm_Load(object sender, EventArgs e)
        {
            foreach (var contact in Contacts)
            {
                Debug.WriteLine(contact);
            }
        }
    }
}
