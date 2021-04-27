using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ERP_JE.Models
{
    public class Contacts
    {
        [ScaffoldColumn(false)]
        public int IdContact { get; set; }
        [Display(Name = "Prénom", Prompt = "Jacques")]
        [Required(ErrorMessage = "Entrez un prénom.")]
        public string LastName { get; set; }
        [Display(Name = "Nom", Prompt = "Chirac")]
        [Required(ErrorMessage = "Entrez un nom.")]
        public string FirstName { get; set; }
        [Display(Name = "Origine du contact", Prompt = "Réseau personnel, LinkedIn...")]
        [Required(ErrorMessage = "Entrez une origine.")]
        public string Origin { get; set; }
        [Display(Name = "Fonction dans l'entreprise", Prompt = "Chef de Projet IT")]
        [Required(ErrorMessage = "Entrez une fonction.")]
        public string Job { get; set; }
        [Required(ErrorMessage = "Entrez un numéro de télphone portable.")]
        [Display(Name = "Numéro de téléphone", Prompt = "0612345678")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Entrez une adresse email.")]
        [Display(Name = "Adresse Email", Prompt = "son.adresse@gmail.com")]
        [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "Format d'adresse non valide.")]
        public string Email { get; set; }
        [Display(Name = "Commentaire", Prompt = "Donnez un petit commentaire sur la personne si besoin.")]
        public string Commentary { get; set; }

        [ScaffoldColumn(false)]
        public int IdCustomer { get; set; }

    }
}
