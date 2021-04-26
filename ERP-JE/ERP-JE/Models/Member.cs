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
        [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "Format d'adresse non valide.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Entrez l'adresse mail de l'école.")]
        [Display(Name = "Adresse Email d'Ecole", Prompt = "son.adresse@edu.devinci.fr")]
        [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "Format d'adresse non valide.")]
        public string SchoolEmail { get; set; }
        [Required(ErrorMessage = "Entrez un numéro de télphone portable.")]
        [Display(Name = "Numéro de téléphone", Prompt = "0612345678")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Entrez une année de promotion.")]
        [Display(Name = "Année de promotion", Prompt = "2024")]
        public string Promo { get; set; }
        [Required(ErrorMessage = "Entrez une école.")]
        [Display(Name = "Ecole", Prompt = "ESILV")]
        public string School { get; set; }
        [Required(ErrorMessage = "Entrez une spécialité.")]
        [Display(Name = "Spécialité", Prompt = "Finance")]
        public string Spe { get; set; }
        [ScaffoldColumn(false)]
        public string Picture { get; set; }
        [ScaffoldColumn(false)]
        public bool Cotisation { get; set; }
        [Required(ErrorMessage = "(Entrez une nationalité.\n(Utilisez un - en séparation si multiples) ")]
        [Display(Name = "Nationalité", Prompt = "Français")]
        public string Nationality { get; set; }
        [ScaffoldColumn(false)]
        public int IdAdhestionBulletin { get; set; }
        [ScaffoldColumn(false)]
        public int IdAdress { get; set; }
        [ScaffoldColumn(false)]
        public int IdUser { get; set; }

        
    }
}   
