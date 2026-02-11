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
        //private FlowLayoutPanel fpContacts;// => this.Parent as FlowLayoutPanel;

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
            //// toggle the isContacted propert and the background color of the control
            //ContactDetails.IsContacted = !ContactDetails.IsContacted;

            //if (ContactDetails.IsContacted)
            //{
            //    this.BackColor = Color.LightGreen;
            //} 
            //else
            //{
            //    this.BackColor = SystemColors.Control;
            //}

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
