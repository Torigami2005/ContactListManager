namespace ContactListManager
{
    partial class MainForm
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
            dgvContacts = new DataGridView();
            btnAddContact = new Button();
            btnEditContact = new Button();
            btnSaveToCSV = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvContacts).BeginInit();
            SuspendLayout();
            // 
            // dgvContacts
            // 
            dgvContacts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvContacts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvContacts.GridColor = SystemColors.MenuHighlight;
            dgvContacts.Location = new Point(12, 57);
            dgvContacts.MultiSelect = false;
            dgvContacts.Name = "dgvContacts";
            dgvContacts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvContacts.Size = new Size(1102, 400);
            dgvContacts.TabIndex = 0;
            dgvContacts.CellContentClick += dgvContacts_CellContentClick;
            // 
            // btnAddContact
            // 
            btnAddContact.Location = new Point(34, 490);
            btnAddContact.Name = "btnAddContact";
            btnAddContact.Size = new Size(170, 67);
            btnAddContact.TabIndex = 1;
            btnAddContact.Text = "Add Contact";
            btnAddContact.UseVisualStyleBackColor = true;
            btnAddContact.Click += btnAddContact_Click;
            // 
            // btnEditContact
            // 
            btnEditContact.Location = new Point(256, 490);
            btnEditContact.Name = "btnEditContact";
            btnEditContact.Size = new Size(170, 67);
            btnEditContact.TabIndex = 2;
            btnEditContact.Text = "Edit Contact";
            btnEditContact.UseVisualStyleBackColor = true;
            btnEditContact.Click += btnEditContact_Click;
            // 
            // btnSaveToCSV
            // 
            btnSaveToCSV.Location = new Point(470, 490);
            btnSaveToCSV.Name = "btnSaveToCSV";
            btnSaveToCSV.Size = new Size(170, 67);
            btnSaveToCSV.TabIndex = 3;
            btnSaveToCSV.Text = "Save to CSV";
            btnSaveToCSV.UseVisualStyleBackColor = true;
            btnSaveToCSV.Click += btnSaveToCSV_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1126, 613);
            Controls.Add(btnSaveToCSV);
            Controls.Add(btnEditContact);
            Controls.Add(btnAddContact);
            Controls.Add(dgvContacts);
            Name = "MainForm";
            Text = "Form1";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvContacts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvContacts;
        private Button btnAddContact;
        private Button btnEditContact;
        private Button btnSaveToCSV;
    }
}
