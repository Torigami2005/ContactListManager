using System.ComponentModel;
using System.Drawing.Text;
using System.Text.RegularExpressions;
namespace ContactListManager
{
    public partial class MainForm : Form
    {
        List<Contact> contacts = new List<Contact>();
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadContactsFromCSV();
        }

        //------------------------------------------------- ADD CONTACT METHOD WITH EMAIL & PHONE NUMBER VALIDATION -------------------------------------------------//
        private void btnAddContact_Click(object sender, EventArgs e)
        {
            Contact newContact = new Contact();
            ContactPopup popup = new ContactPopup(newContact);
            if (popup.ShowDialog() == DialogResult.OK)
            {

                if (!IsValidName(popup.Contact.Name))
                {
                    MessageBox.Show("Please enter a valid name.", 
                        "Invalid Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                    if (!IsValidEmail(popup.Contact.Email))
                {
                    MessageBox.Show("Please enter a valid email address.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                if (!IsValidPhoneNumber(popup.Contact.PhoneNumber))
                {
                    MessageBox.Show("Phone number must contain 11 digits only.", "Invalid Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                } else if (!IsValidPhoneNumber(popup.Contact.PhoneNumber))
                {
                        
                }


                    contacts.Add(popup.Contact);
                UpdateContactGrid();
                SaveContactToCSV();
            }
        }




        //------------------------------------------------- REGEX VALIDATION METHODS -------------------------------------------------//


        private bool IsValidName(string name)
        {
            return !string.IsNullOrWhiteSpace(name) && Regex.IsMatch(name, @"^[a-zA-Z\s]+$");
        }

        private bool IsValidPhoneNumber(string phoneNumber)
        {
            return !string.IsNullOrWhiteSpace(phoneNumber) && Regex.IsMatch(phoneNumber, @"^(09|\+639)\d{9}$");
        }

        private bool IsValidEmail(string email)
        {
            string emailFormat = @"^[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,}$";
            return !string.IsNullOrWhiteSpace(email) && Regex.IsMatch(email, emailFormat);
        }

      
  


        private void dgvContacts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        //------------------------------------------------- LOAD & SAVE CONTACT METHODS -------------------------------------------------//
        private void LoadContactsFromCSV()
        {
            if (!File.Exists("contacts.csv"))
            {
                File.WriteAllText("contacts.csv", "Name,Email,PhoneNumber");
            }
            string[] lines = File.ReadAllLines("contacts.csv");
            foreach (string line in lines.Skip(1))
            {
                var parts = line.Split(',');

                contacts.Add(new Contact
                {
                    Name = parts[0],
                    Email = parts[1],
                    PhoneNumber = parts[2]
                });
            }
            UpdateContactGrid();
        }

        //----------------------------------------------------UPDATE CONTACT GRID METHOD -------------------------------------------------//
        private void UpdateContactGrid()
        {
            dgvContacts.DataSource = null;
            dgvContacts.DataSource = contacts;
            dgvContacts.ReadOnly = true;
        }

        //------------------------------------------------SAVE CONTACT TO CSV METHOD -------------------------------------------------//
        private void SaveContactToCSV()
        {
            var lines = new List<string> { "Name,Email,PhoneNumber" };
            foreach (var contact in contacts)
            {
                lines.Add($"{contact.Name},{contact.Email},{contact.PhoneNumber}");
            }
            File.WriteAllLines("contacts.csv", lines);
            MessageBox.Show("Contacts saved successfully!");

        }

        //------------------------------------------------- EDIT CONTACT METHOD WITH EMAIL & PHONE NUMBER VALIDATION -------------------------------------------------//
        private void btnEditContact_Click(object sender, EventArgs e)
        {
            if (dgvContacts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a contact to edit.");
                return;
            }
            var selectedContact = (Contact)dgvContacts.SelectedRows[0].DataBoundItem;
            ContactPopup popup = new ContactPopup(selectedContact);
            if (popup.ShowDialog() == DialogResult.OK)
            {
                if (!IsValidEmail(popup.Contact.Email))
                {
                    MessageBox.Show("Please enter a valid email address.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!IsValidPhoneNumber(popup.Contact.PhoneNumber))
                {
                    MessageBox.Show("Phone number must contain only digits (0-9).", "Invalid Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                UpdateContactGrid();
                SaveContactToCSV();
            }
        }


        //--------------------------------------------------------- CSV CLICK FILE METHOD -------------------------------------------------//
        private void btnSaveToCSV_Click(object sender, EventArgs e)
        {
            SaveContactToCSV();
            MessageBox.Show("Contact Saved Successfully!");
        }
    }
}