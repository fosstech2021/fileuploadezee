using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using BasePackageModule1.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BasePackageModule1.Models;
using System.IO;
using System.IO.Compression;
using System.Collections.Generic;

namespace BasePackageModule1.Areas.Unibase.Controllers
{
    [Area("Unibase")]

    [Authorize(Roles = "SuperAdmin,Admin")]
    public class UsersController : Controller
    {
        private readonly ApplicationDbContext _db;
        public UsersController(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<IActionResult> Index()
        {
            var claimsIdentity = (ClaimsIdentity)this.User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
            return View(await _db.ApplicationUser.Where(u => u.Id != claim.Value).ToListAsync());
        }
        public async Task<IActionResult> Details(string? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //var applicationUser = await _db.ApplicationUser.FirstOrDefaultAsync(m => m.Id == id);
            //if (applicationUser == null)
            //{
            //    return NotFound();
            //}

            ViewBag.Users = await _db.ApplicationUser.FirstOrDefaultAsync(m => m.Id == id);
            ViewBag.AdminUpload = await _db.ReceivedAgreement.Include(x => x.AgreementDetails).ThenInclude(a => a.ApplicationUser ).Where(a =>a.AgreementDetails.ApplicationUser.Id == id).ToListAsync();

            var AgreementDetails = await _db.AgreementDetails.Include(x => x.ApplicationUser).Where(a =>a.ApplicationUser.Id == id).ToListAsync() ;

            return View(AgreementDetails);
        }
        public async Task<IActionResult> DetailsPopup(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var AgreementDetails = await _db.AgreementDetails.Where(a => a.Id == id).FirstOrDefaultAsync();

            return PartialView("_DetailPopupPartial" , AgreementDetails);
        }
        public async Task<IActionResult> DownloadUserUploadedFile(int id)
        {
            var result = _db.AgreementDetails.FirstOrDefault(X => X.Id == id);
            List<string> AllFile = new List<string> { result.OwnerAdharCardFile, result.OwnerPanCardFile, result.TenantAdharCardFile, result.TenantPanCardFile };
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
        public async Task<IActionResult> DownloadAdminUploadedFile(int id)
        {
            var result = _db.ReceivedAgreement.FirstOrDefault(X => X.Id == id);
            List<string> AllFile = new List<string> { result.DocumentUrl };
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

            return File(zipFileMemoryStream, "appication/octet-stram", $"Zip.ZIP");
        }
        public async Task<IActionResult> UploadDocuments(IFormFile file, int ID)
        {
            if (ID == null || ID == 0)
            {
                return NotFound();
            }
       
            var AgreementDetails = await _db.AgreementDetails.Include(x=>x.ApplicationUser).FirstOrDefaultAsync(m => m.Id == ID);
            string defaultUrl = @"wwwroot\Download\" + AgreementDetails.ApplicationUser.UserName;
            string defaultUrlSave = @"wwwroot\Download\" + AgreementDetails.ApplicationUser.UserName;
            if (!Directory.Exists(Path.Combine(Directory.GetCurrentDirectory(), defaultUrl)))
            {
                Directory.CreateDirectory(Path.Combine(Directory.GetCurrentDirectory(), defaultUrl));
            }

            var Receiveddoc = Guid.NewGuid() + Path.GetExtension(file.FileName);
            var ReceiveddocSavePath = Path.Combine(Directory.GetCurrentDirectory(), defaultUrl, Receiveddoc);
            
            await using (var stream = new FileStream(ReceiveddocSavePath, FileMode.Create))
            {
                file.CopyTo(stream);
            }

            ReceivedAgreement ReceivedAgreement = new ReceivedAgreement();
            ReceivedAgreement.DocumentUrl = Path.Combine(defaultUrlSave, Receiveddoc); ;
            ReceivedAgreement.AgreementDetails = AgreementDetails;
            _db.ReceivedAgreement.Add(ReceivedAgreement);
            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Details) , new { id = AgreementDetails.ApplicationUser.Id } );
          
        }
        public async Task<IActionResult> Lock(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var applicationUser = await _db.ApplicationUser.FirstOrDefaultAsync(m => m.Id == id);
            if (applicationUser == null)
            {
                return NotFound();
            }
            applicationUser.LockoutEnd = DateTime.Now.AddYears(1000);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> UnLock(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var applicationUser = await _db.ApplicationUser.FirstOrDefaultAsync(m => m.Id == id);
            if (applicationUser == null)
            {
                return NotFound();
            }
            applicationUser.LockoutEnd = DateTime.Now;
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
