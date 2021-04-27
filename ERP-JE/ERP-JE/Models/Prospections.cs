﻿using System;
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
    
    public class Prospections //ajouter user id, pour suivre les prospections de chacun
    {
        [ScaffoldColumn(false)]
        public int IdProspection { get; set; }

        public string Needs { get; set; }

        public School ConcernedBu { get; set; }

        public DateTime PreparationDate { get; set; } //Préparation de la prosp

        public Prospection type { get; set; } //Type de prospection

        public Quality firstApproachQuality { get; set; }

        public bool Contacted { get; set; }

        public DateTime ContactDate { get; set; }

        public string LeadedTo { get; set; }

        public string Commentary { get; set; }

        public string OpportunityOfImprovement { get; set; }

        [ScaffoldColumn(false)]
        public int IdContact { get; set; }
    }
}