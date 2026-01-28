

using System.Diagnostics;

#pragma warning disable WFO1000

namespace ContactApp
{
    public partial class ContactForm : Form
    {
        public List<Contact> Contacts { get; set; }

        public ContactForm()
        {
            InitializeComponent();
            Contacts = new List<Contact>();

            for (int i = 0; i < 100000; i++)
            {
                AddContact(new Contact { FirstName = $"{i}", LastName = "person" });
            }

            UpdateContactListBox();
        }

        public void UpdateContactListBox()
        {
            // refreshes the list box with the newest contacts
            lbContacts.Items.Clear();
            foreach (Contact contact in Contacts)
            {
                lbContacts.Items.Add(contact);
            }
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
            //foreach (var contact in Contacts)
            //{
            //    Debug.WriteLine(contact);
            //}
        }

        private void lbContacts_Click(object sender, EventArgs e)
        {
            Contact selectedObj = (Contact) lbContacts.SelectedItem;
            
            if (selectedObj != null)
            {
                int selectedIndex = lbContacts.SelectedIndex;
                Debug.WriteLine($"contact list box was clicked - {selectedObj}");
                
                selectedObj.IsContacted = true;

                lbContacts.Items[selectedIndex] = selectedObj;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // capture the data
            // create a new contact
            Contact newContact = new Contact
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                PhoneNumber = txtPhone.Text,
                Email = txtEmail.Text
            };

            // add it to the list
            Contacts.Add(newContact);

            // pull the lever to update
            UpdateContactListBox();
        }
    }
}
