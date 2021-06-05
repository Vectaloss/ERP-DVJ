using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ERP_JE.Models
{   public enum Prospection
    {
        Phoning, Mailing
    }
    public enum Quality
    {
        Mauvaise, Mitigée, Bonne, Excellente
    }
    public enum Status
    {
        Contacter, Devis, CE, EnCours, Signe, Relancer, Cloture
    }

    public class Prospections //ajouter user id, pour suivre les prospections de chacun
    {
        [ScaffoldColumn(false)]
        public int IdProspection { get; set; }
        [Required(ErrorMessage = "Exprimez le besoin compris duran cette prospection.")]
        [Display(Name = "Exprimez le besoin compris duran cette prospection", Prompt = "L'interlocuteur avait besoin d'un ERP, codé sous la technologie ASP.NET, inculant plusieurs fonctionalités.")]
        public string Needs { get; set; }
        [Required(ErrorMessage = "Selectionnez une BU.")]
        [Display(Name = "Business Unit concernée", Prompt = "")]
        public School ConcernedBu { get; set; }
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Entrez une date de préparation.")]
        [Display(Name = "Date de préparation", Prompt = "09-02-2000")]

        public DateTime PreparationDate { get; set; } //Préparation de la prosp
        [Required(ErrorMessage = "Selectionnez un type de prospection.")]
        [Display(Name = "Type de prospection", Prompt = "")]
        public Prospection type { get; set; } //Type de prospection
        [Required(ErrorMessage = "Entrez un ressenti.")]
        [Display(Name = "Ressenti de l'échange", Prompt = "")]
        public Quality firstApproachQuality { get; set; }


        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Entrez une date de prospection.")]
        [Display(Name = "Date de la prospection", Prompt = "09-02-2000")]

        public DateTime ContactDate { get; set; }

        [Required(ErrorMessage = "Entrez les étapes qui ont suivi le contact.")]
        [Display(Name = "Ce qui a suivi l'entretien", Prompt = "Envoi de la plaquette")]
        public string LeadedTo { get; set; }
        [Display(Name = "Commentaire", Prompt = "Donnez un petit commentaire sur la personne si besoin.")]
        public string Commentary { get; set; }
        [Required(ErrorMessage = "Entrez un numéro de télphone portable.")]
        [Display(Name = "Piste d'amélioration", Prompt = "Donnez une piste d'amélioration pour vous.")]
        public string OpportunityOfImprovement { get; set; }

        [ScaffoldColumn(false)]
        public int IdContact { get; set; }

        [ScaffoldColumn(false)]
        public int IdUser { get; set; }

        public Status Status { get; set; }
    }
}
