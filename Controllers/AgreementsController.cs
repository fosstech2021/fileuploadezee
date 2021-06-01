using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BasePackageModule1.Data;
using BasePackageModule1.Models;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Authorization;

namespace BasePackageModule1.Controllers
{
    public class AgreementsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AgreementsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [Authorize]
        public IActionResult Index()
        {
            return View();
        }


       
        // GET: Agreements/Create
        [Authorize]
        public IActionResult UploadDocument()
        {
            return View();
        }

        // POST: Agreements/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [RequestSizeLimit(90000000)]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UploadDocument(IFormFile OwnerPancard, IFormFile tenantPancard, IFormFile tenantAadharCard, IFormFile AadharCard, Agreement agreement)
        //public async Task<IActionResult> UploadDocument(List<IFormCollection> formCollection)
        {


            if (ModelState.IsValid)


            {
                if (OwnerPancard == null)
                {
                    ModelState.AddModelError("FilePath", "File is required.");
                    return View(agreement);
                }
                if (tenantPancard == null)
                {
                    ModelState.AddModelError("FilePath", "File is required.");
                    return View(agreement);
                }
                if (AadharCard == null)
                {
                    ModelState.AddModelError("FilePath", "File is required.");
                    return View(agreement);
                }
                if (tenantAadharCard == null)
                {
                    ModelState.AddModelError("FilePath", "File is required.");
                    return View(agreement);
                }



                if (!Directory.Exists(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Download")))
                {
                    Directory.CreateDirectory(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Download"));
                }


                var ownerpancard = Guid.NewGuid() + Path.GetExtension(OwnerPancard.FileName);
                var tententpancard = Guid.NewGuid() + Path.GetExtension(tenantPancard.FileName);
                var owneraadharcard = Guid.NewGuid() + Path.GetExtension(AadharCard.FileName);
                var tententaadharcard = Guid.NewGuid() + Path.GetExtension(tenantAadharCard.FileName);
                //Get url To Save
                var ownerpancardsavePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Download", ownerpancard);
                var tententpancardsavePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Download", tententpancard);
                var owneraadharcardsavePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Download", owneraadharcard);
                var tententaadharcardsavePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Download", tententaadharcard);

                await using (var stream = new FileStream(ownerpancardsavePath, FileMode.Create))
                {
                    OwnerPancard.CopyTo(stream);
                }
                await using (var stream = new FileStream(tententpancardsavePath, FileMode.Create))
                {
                    tenantPancard.CopyTo(stream);
                }
                await using (var stream = new FileStream(tententaadharcardsavePath, FileMode.Create))
                {
                    tenantAadharCard.CopyTo(stream);
                }
                await using (var stream = new FileStream(owneraadharcardsavePath, FileMode.Create))
                {
                    AadharCard.CopyTo(stream);
                }

              
                agreement.tenantPancard = $"/Download/{tententpancard}";
                agreement.AadharCard = $"/Download/{owneraadharcard}";
                agreement.tenantAadharCard = $"/Download/{tententaadharcard}";
                
               


                _context.Add(agreement);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(agreement);
        }

        // GET: Agreements/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var agreement = await _context.Agreements.FindAsync(id);
            if (agreement == null)
            {
                return NotFound();
            }
            return View(agreement);
        }

        // POST: Agreements/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,OwnerFullName,OwnerMobile,OwnerPancard,AadharCard,tenantFullName,tenantMobile,tenantPancard,tenantAadharCard,RentOnPremises")] Agreement agreement)
        {
            if (id != agreement.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(agreement);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AgreementExists(agreement.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(agreement);
        }

        // GET: Agreements/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var agreement = await _context.Agreements
                .FirstOrDefaultAsync(m => m.Id == id);
            if (agreement == null)
            {
                return NotFound();
            }

            return View(agreement);
        }

        // POST: Agreements/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var agreement = await _context.Agreements.FindAsync(id);
            _context.Agreements.Remove(agreement);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AgreementExists(int id)
        {
            return _context.Agreements.Any(e => e.Id == id);
        }
    }
}
