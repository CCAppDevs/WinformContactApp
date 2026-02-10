namespace ContactApp
{
    partial class ContactControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblFullNameLabel = new Label();
            lblFullName = new Label();
            lblPhoneNumber = new Label();
            lblPhoneLabel = new Label();
            lblAddress = new Label();
            lblAddressLabel = new Label();
            btnMarkContacted = new Button();
            SuspendLayout();
            // 
            // lblFullNameLabel
            // 
            lblFullNameLabel.AutoSize = true;
            lblFullNameLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFullNameLabel.Location = new Point(3, 5);
            lblFullNameLabel.Name = "lblFullNameLabel";
            lblFullNameLabel.Size = new Size(66, 25);
            lblFullNameLabel.TabIndex = 0;
            lblFullNameLabel.Text = "Name:";
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFullName.Location = new Point(75, 5);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(91, 25);
            lblFullName.TabIndex = 1;
            lblFullName.Text = "John Doe";
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPhoneNumber.Location = new Point(153, 30);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(137, 25);
            lblPhoneNumber.TabIndex = 3;
            lblPhoneNumber.Text = "(360) 555-1212";
            // 
            // lblPhoneLabel
            // 
            lblPhoneLabel.AutoSize = true;
            lblPhoneLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPhoneLabel.Location = new Point(3, 30);
            lblPhoneLabel.Name = "lblPhoneLabel";
            lblPhoneLabel.Size = new Size(144, 25);
            lblPhoneLabel.TabIndex = 2;
            lblPhoneLabel.Text = "Phone Number:";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAddress.Location = new Point(92, 55);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(174, 25);
            lblAddress.TabIndex = 5;
            lblAddress.Text = "person@email.com";
            // 
            // lblAddressLabel
            // 
            lblAddressLabel.AutoSize = true;
            lblAddressLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAddressLabel.Location = new Point(3, 55);
            lblAddressLabel.Name = "lblAddressLabel";
            lblAddressLabel.Size = new Size(83, 25);
            lblAddressLabel.TabIndex = 4;
            lblAddressLabel.Text = "Address:";
            // 
            // btnMarkContacted
            // 
            btnMarkContacted.Location = new Point(323, 9);
            btnMarkContacted.Name = "btnMarkContacted";
            btnMarkContacted.Size = new Size(75, 23);
            btnMarkContacted.TabIndex = 6;
            btnMarkContacted.Text = "Contact";
            btnMarkContacted.UseVisualStyleBackColor = true;
            btnMarkContacted.Click += btnMarkContacted_Click;
            // 
            // ContactControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnMarkContacted);
            Controls.Add(lblAddress);
            Controls.Add(lblAddressLabel);
            Controls.Add(lblPhoneNumber);
            Controls.Add(lblPhoneLabel);
            Controls.Add(lblFullName);
            Controls.Add(lblFullNameLabel);
            Name = "ContactControl";
            Size = new Size(401, 89);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFullNameLabel;
        private Label lblFullName;
        private Label lblPhoneNumber;
        private Label lblPhoneLabel;
        private Label lblAddress;
        private Label lblAddressLabel;
        private Button btnMarkContacted;
    }
}
