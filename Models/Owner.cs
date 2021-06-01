using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BasePackageModule1.Models
{
    public class Owner
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Owner Full Name")]
        public string OwnerFullName { get; set; }

        [Required]
        [Display(Name = "Mobile No.")]
        [MaxLength(10)]
        public string OwnerMobile { get; set; }

        [Required]
        [Display(Name = "Owner Pancard")]
        public string OwnerPancard { get; set; }

        [Required]
        [Display(Name = "Owner Aadhaar")]
        public string AadharCard { get; set; }

        public Agreement Agreement { get; set; }

        public int AgreementId { get; set; }
    }
}
