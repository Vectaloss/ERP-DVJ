using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERP_JE.Models
{
    public class Contacts
    {
        public int IdContact { get; set; }
        
        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string Origin { get; set; }

        public string Job { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string Commentary { get; set; }

        public int IdCustomer { get; set; }

    }
}
