using System.ComponentModel;
using System.Drawing.Text;

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

        private void btnAddContact_Click(object sender, EventArgs e)
        {
            Contact newContact = new Contact();
            ContactPopup popup = new ContactPopup(newContact);
            if (popup.ShowDialog() == DialogResult.OK)
            {
                contacts.Add(popup.Contact);
                UpdateContactGrid();
                SaveContactToCSV();
            }
        }

        private void dgvContacts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

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

        private void UpdateContactGrid()
        {
            dgvContacts.DataSource = null;
            dgvContacts.DataSource = contacts;
            dgvContacts.ReadOnly = true;
        }

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
                UpdateContactGrid();
                SaveContactToCSV();
            }
        }

        private void btnSaveToCSV_Click(object sender, EventArgs e)
        {
            SaveContactToCSV();
            MessageBox.Show("Contact Saved Successfully!");
        }
    }
}
