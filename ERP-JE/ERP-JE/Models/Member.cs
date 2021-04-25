using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ERP_JE.Models
{
    public class Member
    {
        [Required]
        public int IdMember { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }

        public DateTime Birth { get; set; }
        public string Email { get; set; }
        public string SchoolEmail { get; set; }
        public string Phone { get; set; }
        public string Promo { get; set; }
        public string School { get; set; }
        public string Spe { get; set; }
        public string Picture { get; set; }
        public string Cotisation { get; set; }
        public string Nationality { get; set; }
        public string IdAdhestionBulletin { get; set; }
        public string IdAdress { get; set; }
        public string IdUser { get; set; }

        public Member(int id, string prenom, string Nom)
        {
            IdMember = id;
            FirstName = prenom;
            LastName = Nom;
        }
    }
}   
