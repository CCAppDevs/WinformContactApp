using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactApp
{
    public partial class ContactControl : UserControl
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Contact ContactDetails { get; set; }

        public ContactControl(Contact contactDetails)
        {
            InitializeComponent();
            ContactDetails = contactDetails;

            // fill in all of the details on the control using the data
            lblFullName.Text = ContactDetails.FullName;
            lblAddress.Text = ContactDetails.Email;
            lblPhoneNumber.Text = ContactDetails.PhoneNumber;
        }

        private void btnMarkContacted_Click(object sender, EventArgs e)
        {
            // delete myself from the fpContacts panel on the base form
            var frm = this.Parent?.Parent as ContactForm;

            if (frm != null)
            {
                frm.Contacts.Remove(ContactDetails);
                frm.UpdateContactList();
            }
        }
    }
}
