using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ERP_JE.Models
{
    public enum status { EnCours, Clôturé, EnPerte }
    public class Studies
    {
        [ScaffoldColumn(false)]
        public int IdStudy { get; set; }

        public string NickName { get; set; }

        public string Description { get; set; }

        public int Mandate { get; set; }

        public bool Confidenial { get; set; }

        [ScaffoldColumn(false)]
        public status Status { get; set; }

        [ScaffoldColumn(false)]
        public int IdAmendmentSA { get; set; }

        [ScaffoldColumn(false)]
        public int IdAmendmentMS { get; set; }

        [ScaffoldColumn(false)]
        public int IdPVRF { get; set; }

        [ScaffoldColumn(false)]
        public int IdFinalInvoice { get; set; }

        [ScaffoldColumn(false)]
        public int IdPedacogicalReport { get; set; }

        [ScaffoldColumn(false)]
        public int IdDespositInvoice { get; set; }

        [ScaffoldColumn(false)]
        public int IdMissionSummary { get; set; }

        [Required]
        public int IdStudyAgreement { get; set; }

        [ScaffoldColumn(false)]
        public int IdCustomer { get; set; }
    }
}
