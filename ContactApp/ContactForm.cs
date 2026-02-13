
// The following using statement is required for this code to function
using System.ComponentModel;

// Disable the warning on Contacts
#pragma warning disable WFO1000

namespace ContactApp
{
    public partial class ContactForm : Form
    {
        // Properties

        // Note the type change of the list:
        //    this is a more specific version of a List meant for this task
        //    It contains special events that are called when the list changes (ItemAdded and ItemDeleted)
        public BindingList<Contact> Contacts { get; set; } 

        // This is a special class that is responsible for triggering what happens when events fire from the Contacts property above.
        private BindingSource contactBindingSource;

        // Constructor
        public ContactForm()
        {
            InitializeComponent();

            // Create the empty Contacts list
            Contacts = new BindingList<Contact>();
            // Create a new BindingSource
            contactBindingSource = new BindingSource();
            // Set the DataSource property on the binding source to Contact List
            contactBindingSource.DataSource = Contacts;

            // Bind the event handler (method) to call (invoke) when the source list changes
            contactBindingSource.ListChanged += ContactBindingSource_ListChanged;
        }

        // Event handler to handle when the Contacts list changes.
        //    On Item added: add a new contact control
        //    On Item deleted: Refresh the entire list
        private void ContactBindingSource_ListChanged(object? sender, ListChangedEventArgs e)
        {
            // This method is called by the binding source and is given information about the event:
            //     sender = The object in code triggering the change
            //     e = Details about the event that is being fired, such as what type of change happened (add, delete, etc)
            
            if (e.ListChangedType == ListChangedType.ItemAdded) // handle an item being added to the list
            {
                var contact = Contacts[e.NewIndex];
                AddContactControl(contact);
            }
            else if (e.ListChangedType == ListChangedType.ItemDeleted) // handle an item being removed from the list
            {
                fpContacts.Controls.Clear();

                foreach (var contact in Contacts)
                {
                    AddContactControl(contact);
                }
            }
        }

        // Helper method to create a new contact control and add it to fpContacts
        private void AddContactControl(Contact contact)
        {
            var item = new ContactControl(contact);
            fpContacts.Controls.Add(item);
        }

        // Helper method to add a contact to the contacts list
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

        // Helper method to add a contact to the contacts list
        public void AddContact(Contact contact)
        {
            Contacts.Add(contact);
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

            // add it to the list, this triggers the data binding to update fpContacts automatically.
            Contacts.Add(newContact);

            // Clear the form so we can add a new contact
            ClearForm();
            txtFirstName.Focus();
        }

        // Clear the form so we can insert a new contact
        private void ClearForm()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
        }

        // event handler for clicking the clear button
        private void btnClear_Clicked(object sender, EventArgs e)
        {
            ClearForm();
            txtFirstName.Focus();
        }
    }
}
