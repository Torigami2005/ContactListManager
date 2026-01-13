namespace ContactListManager
{
    partial class ContactPopup
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtName = new TextBox();
            txtEmail = new TextBox();
            txtPhoneNumber = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            labelName = new Label();
            labelEmail = new Label();
            labelPN = new Label();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(12, 92);
            txtName.Name = "txtName";
            txtName.Size = new Size(291, 23);
            txtName.TabIndex = 0;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(326, 92);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(233, 23);
            txtEmail.TabIndex = 1;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(591, 92);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(245, 23);
            txtPhoneNumber.TabIndex = 2;
            txtPhoneNumber.TextChanged += txtPhoneNumber_TextChanged;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(239, 162);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(108, 53);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click_1;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(434, 162);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(108, 53);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click_1;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(12, 74);
            labelName.Name = "labelName";
            labelName.Size = new Size(39, 15);
            labelName.TabIndex = 5;
            labelName.Text = "Name";
            labelName.Click += labelName_Click;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(326, 74);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(36, 15);
            labelEmail.TabIndex = 6;
            labelEmail.Text = "Email";
            labelEmail.Click += label1_Click;
            // 
            // labelPN
            // 
            labelPN.AutoSize = true;
            labelPN.Location = new Point(591, 74);
            labelPN.Name = "labelPN";
            labelPN.Size = new Size(88, 15);
            labelPN.TabIndex = 7;
            labelPN.Text = "Phone Number";
            labelPN.Click += label1_Click_1;
            // 
            // ContactPopup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(848, 272);
            Controls.Add(labelPN);
            Controls.Add(labelEmail);
            Controls.Add(labelName);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Name = "ContactPopup";
            Text = "ContactPopup";
            Load += ContactPopup_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox txtPhoneNumber;
        private Button btnSave;
        private Button btnCancel;
        private Label labelName;
        private Label labelEmail;
        private Label labelPN;
    }
}