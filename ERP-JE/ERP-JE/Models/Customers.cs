using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERP_JE.Models
{
    public enum Size
    {
        Autoentrepreneur, GE, ETI, PME, TPE
    }
    public class Customers
    {
        public int IdCustomer { get; set; }


        public string Name { get; set; }

        public int IdAdress { get; set; }

        public int SIREN { get; set; }

        public string Sector { get; set; }

        public string Website { get; set; }

        public Size Size { get; set; }
    }
}
