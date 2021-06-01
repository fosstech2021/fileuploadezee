using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using BasePackageModule1.Data;
using BasePackageModule1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BasePackageModule1.Areas.Identity.Pages.Account.CreateAgreement
{
    public class IndexModel : PageModel
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly ApplicationDbContext _context;

        public IndexModel(
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager , ApplicationDbContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;
        }

        public AgreementDetailsFileData AgreementDetailsFileData { get; set; }
        public void OnGet()
        {
        }

        public async Task OnPostAsync(AgreementDetailsFileData AgreementDetailsFileData)
        {
            if (ModelState.IsValid)
            {
                var ownerpancard = Guid.NewGuid() + Path.GetExtension(AgreementDetailsFileData.OwnerPanCardFile.FileName);
                var tententpancard = Guid.NewGuid() + Path.GetExtension(AgreementDetailsFileData.TenantPanCardFile.FileName);
                var owneraadharcard = Guid.NewGuid() + Path.GetExtension(AgreementDetailsFileData.TenantAdharCardFile.FileName);
                var tententaadharcard = Guid.NewGuid() + Path.GetExtension(AgreementDetailsFileData.TenantAdharCardFile.FileName);

                string defaultUrl = @"wwwroot\Download\" + this.User.Identity.Name;
                string defaultUrlSave = @"wwwroot\Download\" + this.User.Identity.Name;
                if (!Directory.Exists(Path.Combine(Directory.GetCurrentDirectory(), defaultUrl)))
                {
                    Directory.CreateDirectory(Path.Combine(Directory.GetCurrentDirectory(), defaultUrl));
                }

                var ownerpancardsavePath = Path.Combine(Directory.GetCurrentDirectory(), defaultUrl, ownerpancard);
                var tententpancardsavePath = Path.Combine(Directory.GetCurrentDirectory(), defaultUrl, tententpancard);
                var owneraadharcardsavePath = Path.Combine(Directory.GetCurrentDirectory(), defaultUrl, owneraadharcard);
                var tententaadharcardsavePath = Path.Combine(Directory.GetCurrentDirectory(), defaultUrl, tententaadharcard);


                await using (var stream = new FileStream(ownerpancardsavePath, FileMode.Create))
                {
                    AgreementDetailsFileData.OwnerPanCardFile.CopyTo(stream);
                }
                await using (var stream = new FileStream(tententpancardsavePath, FileMode.Create))
                {
                    AgreementDetailsFileData.TenantPanCardFile.CopyTo(stream);
                }
                await using (var stream = new FileStream(tententaadharcardsavePath, FileMode.Create))
                {
                    AgreementDetailsFileData.TenantAdharCardFile.CopyTo(stream);
                }
                await using (var stream = new FileStream(owneraadharcardsavePath, FileMode.Create))
                {
                    AgreementDetailsFileData.OwnerAdharCardFile.CopyTo(stream);
                }



                //Get url To Save
                AgreementDetails _agreementDetails = new AgreementDetails();
                _agreementDetails.OwnerPanCardFile = Path.Combine(defaultUrlSave, ownerpancard);
                _agreementDetails.TenantPanCardFile = Path.Combine(defaultUrlSave, tententpancard);
                _agreementDetails.OwnerAdharCardFile = Path.Combine(defaultUrlSave, owneraadharcard);
                _agreementDetails.TenantAdharCardFile = Path.Combine(defaultUrlSave, tententaadharcard);

                _agreementDetails.ApplicationUser = (ApplicationUser)await _userManager.GetUserAsync(User);

                _agreementDetails.OwnerAddress = AgreementDetailsFileData.OwnerAddress;
                _agreementDetails.OwnerFirstName = AgreementDetailsFileData.OwnerFirstName;
                _agreementDetails.OwnerMiddleName = AgreementDetailsFileData.OwnerMiddleName;
                _agreementDetails.OwnerLastName = AgreementDetailsFileData.OwnerLastName;
                _agreementDetails.OwnerPan = AgreementDetailsFileData.OwnerPan;
                _agreementDetails.OwnerAge = AgreementDetailsFileData.OwnerAge;
                _agreementDetails.OwnerSalutation = AgreementDetailsFileData.OwnerSalutation;

                _agreementDetails.TenantSalutation = AgreementDetailsFileData.TenantSalutation;
                _agreementDetails.TenantAddress = AgreementDetailsFileData.TenantAddress;
                _agreementDetails.TenantFirstName = AgreementDetailsFileData.TenantFirstName;
                _agreementDetails.TenantMiddleName = AgreementDetailsFileData.TenantMiddleName;
                _agreementDetails.TenantLastName = AgreementDetailsFileData.TenantLastName;
                _agreementDetails.TenantPan = AgreementDetailsFileData.TenantPan;
                _agreementDetails.TenantAge = AgreementDetailsFileData.TenantAge;
                _agreementDetails.AverageRent= AgreementDetailsFileData.AverageRent;
                _agreementDetails.SecurityDeposit= AgreementDetailsFileData.SecurityDeposit;
                _agreementDetails.Noofmonths= AgreementDetailsFileData.Noofmonths;
                _agreementDetails.StartDate= AgreementDetailsFileData.StartDate;
                _agreementDetails.PropertyType = AgreementDetailsFileData.PropertyType;
                _agreementDetails.PropertyUse= AgreementDetailsFileData.PropertyUse;
                _agreementDetails.Location= AgreementDetailsFileData.Location;
                _agreementDetails.PropertyDetails = AgreementDetailsFileData.PropertyDetails;


                _context.Add(_agreementDetails);
                await _context.SaveChangesAsync();
            }

        }
    }
}