using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ERP_JE.Models
{
    public class Member
    {
        [ScaffoldColumn(false)]
        public int IdMember { get; set; }
        [Display(Name = "Prénom", Prompt = "Jacques")]
        [Required(ErrorMessage = "Entrez un prénom.")]
        public string FirstName { get; set; }
        [Display(Name = "Nom", Prompt = "Chirac")]
        [Required(ErrorMessage = "Entrez un nom.")]
        public string LastName { get; set; }
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Entrez une date de naissance.")]
        [Display(Name = "Date de naissance", Prompt = "12/09/2000")]
        public DateTime Birth { get; set; }
        
        [Required(ErrorMessage = "Entrez une adresse email.")]
        [Display(Name = "Adresse Email", Prompt = "son.adresse@gmail.com")]
        [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "Email is not valid.")]
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
