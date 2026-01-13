using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactListManager
{


    public class Contact
    {
        public Contact()
        {
        }

  

        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public Contact SelectedContact { get; }
    }


    

}
