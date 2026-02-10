

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

            //for (int i = 0; i < 100000; i++)
            //{
            //    AddContact(new Contact { FirstName = $"{i}", LastName = "person" });
            //}

            UpdateContactList();
        }

        public void UpdateContactList()
        {
            // refreshes the list box with the newest contacts
            
            fpContacts.Controls.Clear();

            foreach (Contact contact in Contacts)
            {
                fpContacts.Controls.Add(new ContactControl(contact));
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
            //Contact selectedObj = (Contact)lbContacts.SelectedItem;

            //if (selectedObj != null)
            //{
            //    int selectedIndex = lbContacts.SelectedIndex;
            //    Debug.WriteLine($"contact list box was clicked - {selectedObj}");

            //    selectedObj.IsContacted = true;

            //    lbContacts.Items[selectedIndex] = selectedObj;

            //    // show message box saying we contacted them
            //    MessageBox.Show($"Contacted customer: {selectedObj.FirstName}. Marked status to contacted.", "Success");
            //}

            // TODO: do i even need this?
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // validate the data, pull a ripcord if it fails validation
            if (txtFirstName.Text.Length <= 0) // check if first name does not contains data
            {
                // no text, fail
                MessageBox.Show("First name must contain at least one letter.");
                txtFirstName.Focus();
                return;
            }

            // validate the data, pull a ripcord if it fails validation
            if (txtLastName.Text.Length <= 0) // check if last name does not contains data
            {
                // no text, fail
                MessageBox.Show("Last name must contain at least one letter.");
                txtLastName.Focus();
                return;
            }

            // validate the data, pull a ripcord if it fails validation
            if (txtEmail.Text.Length <= 0 && txtPhone.Text.Length <= 0) // check if email does not contains data 
            {
                // no text, fail
                MessageBox.Show("You must have either a phone number or a contact for this customer.");
                txtPhone.Focus();
                return;
            }

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
            UpdateContactList();
            ClearForm();
            txtFirstName.Focus();
        }

        private void ClearForm()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
        }

        private void btnClear_Clicked(object sender, EventArgs e)
        {
            ClearForm();
            txtFirstName.Focus();
        }
    }
}
