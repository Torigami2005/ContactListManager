using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactListManager
{
    public partial class ContactPopup : Form
    {
        public Contact Contact { get; internal set; }

        public ContactPopup(Contact newContact)
        {
            InitializeComponent();
            Contact = newContact;

            btnSave.Click += BtnSave_Click;
            btnCancel.Click += BtnCancel_Click;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Contact.Name = txtName.Text;
            Contact.Email = txtEmail.Text;
            Contact.PhoneNumber = txtPhoneNumber.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void ContactPopup_Load(object sender, EventArgs e)
        {
            if (Contact != null)
            {
                txtName.Text = Contact.Name;
                txtEmail.Text = Contact.Email;
                txtPhoneNumber.Text = Contact.PhoneNumber;
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (Contact != null)
            {
                Contact.Name = txtName.Text;
            }

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (Contact != null)
            {
                Contact.Email = txtEmail.Text;
            }
        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            if (Contact != null)
            {
                Contact.PhoneNumber = txtPhoneNumber.Text;
            }
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {

        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }
    }
}