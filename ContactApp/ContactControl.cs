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

            // fill in all of the details on the control using data binding
            lblFullName.DataBindings.Add("Text", ContactDetails, "FullName");
            lblAddress.DataBindings.Add("Text", ContactDetails, "Email");
            lblPhoneNumber.DataBindings.Add("Text", ContactDetails, "PhoneNumber");
        }

        private void btnMarkContacted_Click(object sender, EventArgs e)
        {
            // delete myself from the fpContacts panel on the base form
            var frm = this.Parent?.Parent as ContactForm;

            if (frm != null)
            {
                // reach into the form and delete this contact from the contacts list
                // this triggers the data binding to delete the control automatically
                frm.Contacts.Remove(ContactDetails);
            }
        }
    }
}
