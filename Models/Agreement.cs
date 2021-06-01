using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BasePackageModule1.Models
{
    public class Agreement 
    {
        public int Id { get; set; }
       

        [Required]
        [Display(Name = "Tenant Full Name")]
        public string tenantFullName { get; set; }
        [Required]
        [Display(Name = "Mobile No.")]
        [MaxLength(10)]
        public string tenantMobile { get; set; }

        [Required]
        [Display(Name = "Tenant Pancard")]
        public string tenantPancard { get; set; }
        [Required]
        [Display(Name = "Tenant Aadhaar")]
        public string tenantAadharCard { get; set; }

        [Required]
        [Display(Name = "Premises On Rent")]
        public string RentOnPremises { get; set; }
      

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



    }

    public class CreateAgreementDetails
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string PropertyDetails { get; set; }
        [Required]
        public string Location { get; set; }
        [Required]
        public string PropertyType { get; set; }
        [Required]
        public string PropertyUse { get; set; }

        [Required]
        public string OwnerFirstName { get; set; }
        public string OwnerMiddleName { get; set; }
        public string OwnerLastName { get; set; }
        [Required]
        public string OwnerSalutation { get; set; }
        [Required]
        public string OwnerAge { get; set; }
        [Required]
        public string OwnerPan { get; set; }
        [Required]
        public string OwnerAddress { get; set; }
        [Required]
        public string TenantFirstName { get; set; }
        public string TenantMiddleName { get; set; }
        public string TenantLastName { get; set; }
        [Required]

        public string TenantSalutation { get; set; }
        [Required]

        public string TenantAge { get; set; }
        [Required]

        public string TenantPan { get; set; }
        [Required]

        public string TenantAddress { get; set; }
        [Required]
        public string AverageRent { get; set; }
        [Required]
        public string SecurityDeposit { get; set; }
        public string Noofmonths { get; set; }
        public DateTime StartDate { get; set; }


        [ForeignKey("ApplicationUserId")]
        public virtual ApplicationUser ApplicationUser { get; set; }
    }

    public class AgreementDetailsFileData : CreateAgreementDetails
    {

        [Required]
        public IFormFile OwnerAdharCardFile { get; set; }
        [Required]
        public IFormFile OwnerPanCardFile { get; set; }

        [Required]

        public IFormFile TenantAdharCardFile { get; set; }
        [Required]
        public IFormFile TenantPanCardFile { get; set; }
     
    }

    public class AgreementDetails : CreateAgreementDetails
    {
        [Required]
        public string OwnerAdharCardFile { get; set; }
        [Required]
        public string OwnerPanCardFile { get; set; }

        [Required]

        public string TenantAdharCardFile { get; set; }
        [Required]
        public string TenantPanCardFile { get; set; }
    }
}
