using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Threading.Tasks;
using BasePackageModule1.Data;
using BasePackageModule1.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BasePackageModule1.Areas.Identity.Pages.Account.MyAgreement
{
    
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public readonly UserManager<IdentityUser> _userManager;
        public IndexModel(UserManager<IdentityUser> userManager,  ApplicationDbContext context)
        {
            _userManager = userManager;
            _context = context;
        }
        
        [BindProperty]
        public List<AgreementDetails> ArrayAgreementDetails { get; set; }
        public AgreementDetails AgreementDetails { get; set; }


        public async Task<IActionResult> OnGetAsync()
        {
            ApplicationUser ApplicationUser = (ApplicationUser)await _userManager.GetUserAsync(User);
            ArrayAgreementDetails  =  _context.AgreementDetails.Where(X => X.ApplicationUser == ApplicationUser).ToList();
            return Page();
        }

        public async Task<IActionResult> OnPostDownloadFileAsync(int id )
        {
             var result = _context.AgreementDetails.FirstOrDefault(X => X.Id== id);
            List<string> AllFile= new List<string> { result.OwnerAdharCardFile, result.OwnerPanCardFile, result.TenantAdharCardFile, result.TenantPanCardFile };
            FileStream originalFileStream = null;


            //var botsFolderPath = Path.Combine("root", "bots");
            //var botFilePaths = Directory.GetFiles(botsFolderPath);
            var zipFileMemoryStream = new MemoryStream();
            using (ZipArchive archive = new ZipArchive(zipFileMemoryStream, ZipArchiveMode.Update, leaveOpen: true))
            {
                foreach (var botFilePath in AllFile)
                {
                    var botFileName = Path.GetFileName(botFilePath);
                    var entry = archive.CreateEntry(botFileName);
                    using (var entryStream = entry.Open())
                    using (var fileStream = System.IO.File.OpenRead(botFilePath))
                    {
                        await fileStream.CopyToAsync(entryStream);
                    }
                }
            }

            zipFileMemoryStream.Seek(0, SeekOrigin.Begin);

            return File(zipFileMemoryStream, "appication/octet-stram", $"Zip{result.StartDate }.ZIP");
        }
        
    }
}
