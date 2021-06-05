using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [ScaffoldColumn(false)]
        public int IdCustomer { get; set; }

        [Display(Name = "Nom du client", Prompt = "Dassault Aviation")]
        [Required(ErrorMessage = "Entrez un nom d'entreprise.")]
        public string Name { get; set; }
        [ScaffoldColumn(false)]
        public int IdAdress { get; set; }
        [Display(Name = "SIREN", Prompt = "123456789")]
        [Required(ErrorMessage = "Entrez un SIREN.")]
        public int SIREN { get; set; }
        [Display(Name = "Secteur d'activité", Prompt = "Aéronautique")]
        [Required(ErrorMessage = "Entrez un secteur d'activité.")]
        public string Sector { get; set; }
        [Display(Name = "Site web", Prompt = "https://www.dassault-aviation.com/fr/")]
        [Required(ErrorMessage = "Entrez un site web.")]
        public string Website { get; set; }
        [Display(Name = "Taille", Prompt = "PME")]
        [Required(ErrorMessage = "Séléctionnez une taille d'entreprise.")]
        public Size Size { get; set; }
    }
}
