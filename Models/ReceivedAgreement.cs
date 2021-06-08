using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BasePackageModule1.Models
{
    public class ReceivedAgreement
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string DocumentUrl { get; set; }
        [Required]
        [ForeignKey("AgreementDetailsId")]
        public AgreementDetails AgreementDetails { get; set; }
    }
}
