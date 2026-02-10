namespace ContactApp
{
    partial class ContactForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gbContact = new GroupBox();
            btnClear = new Button();
            btnSave = new Button();
            txtEmail = new TextBox();
            label2 = new Label();
            txtPhone = new TextBox();
            lblPhone = new Label();
            txtLastName = new TextBox();
            lblLastName = new Label();
            txtFirstName = new TextBox();
            lblFirstName = new Label();
            fpContacts = new FlowLayoutPanel();
            gbContact.SuspendLayout();
            SuspendLayout();
            // 
            // gbContact
            // 
            gbContact.AutoSize = true;
            gbContact.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            gbContact.Controls.Add(btnClear);
            gbContact.Controls.Add(btnSave);
            gbContact.Controls.Add(txtEmail);
            gbContact.Controls.Add(label2);
            gbContact.Controls.Add(txtPhone);
            gbContact.Controls.Add(lblPhone);
            gbContact.Controls.Add(txtLastName);
            gbContact.Controls.Add(lblLastName);
            gbContact.Controls.Add(txtFirstName);
            gbContact.Controls.Add(lblFirstName);
            gbContact.Dock = DockStyle.Top;
            gbContact.Location = new Point(0, 0);
            gbContact.Name = "gbContact";
            gbContact.Size = new Size(499, 212);
            gbContact.TabIndex = 0;
            gbContact.TabStop = false;
            gbContact.Text = "Contact Form";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(332, 167);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 9;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Clicked;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(413, 167);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.None;
            txtEmail.Location = new Point(76, 120);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(414, 23);
            txtEmail.TabIndex = 7;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(12, 120);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 6;
            label2.Text = "Email";
            // 
            // txtPhone
            // 
            txtPhone.Anchor = AnchorStyles.None;
            txtPhone.Location = new Point(76, 88);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(414, 23);
            txtPhone.TabIndex = 5;
            // 
            // lblPhone
            // 
            lblPhone.Anchor = AnchorStyles.None;
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(12, 91);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(51, 15);
            lblPhone.TabIndex = 4;
            lblPhone.Text = "Phone #";
            // 
            // txtLastName
            // 
            txtLastName.Anchor = AnchorStyles.None;
            txtLastName.Location = new Point(76, 59);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(414, 23);
            txtLastName.TabIndex = 3;
            // 
            // lblLastName
            // 
            lblLastName.Anchor = AnchorStyles.None;
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(12, 62);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(63, 15);
            lblLastName.TabIndex = 2;
            lblLastName.Text = "Last Name";
            // 
            // txtFirstName
            // 
            txtFirstName.Anchor = AnchorStyles.None;
            txtFirstName.Location = new Point(76, 30);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(414, 23);
            txtFirstName.TabIndex = 1;
            // 
            // lblFirstName
            // 
            lblFirstName.Anchor = AnchorStyles.None;
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(12, 30);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(64, 15);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "First Name";
            // 
            // fpContacts
            // 
            fpContacts.AutoScroll = true;
            fpContacts.AutoSize = true;
            fpContacts.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            fpContacts.Dock = DockStyle.Fill;
            fpContacts.FlowDirection = FlowDirection.TopDown;
            fpContacts.Location = new Point(0, 212);
            fpContacts.Name = "fpContacts";
            fpContacts.Size = new Size(499, 249);
            fpContacts.TabIndex = 1;
            fpContacts.WrapContents = false;
            // 
            // ContactForm
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(499, 461);
            Controls.Add(fpContacts);
            Controls.Add(gbContact);
            Name = "ContactForm";
            Text = "Contacts";
            Load += ContactForm_Load;
            gbContact.ResumeLayout(false);
            gbContact.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbContact;
        private TextBox txtFirstName;
        private Label lblFirstName;
        private TextBox txtLastName;
        private Label lblLastName;
        private TextBox txtEmail;
        private Label label2;
        private TextBox txtPhone;
        private Label lblPhone;
        private Button btnSave;
        private Button btnClear;
        private FlowLayoutPanel fpContacts;
    }
}
