using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using BasePackageModule1.Data;
using BasePackageModule1.Helpers;
using BasePackageModule1.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BasePackageModule1.Areas.Unibase.Controllers
{
    public class TestimonialController : Controller
    {
        [Area("Unibase")]
        [Authorize(Roles = "SuperAdmin,Admin")]
        public class TestimonialsController : Controller
        {
            private readonly ApplicationDbContext _context;
            public TestimonialsController(ApplicationDbContext context)
            {
                _context = context;
            }
            // GET: Admin/Posts
            public async Task<IActionResult> Index()
            {
                return View(await _context.Testimonials.ToListAsync());
            }

            // GET: Admin/Posts/Details/5
            public async Task<IActionResult> Details(int? id)
            {
                if (id == null)
                {
                    return NotFound();
                }

                var post = await _context.Testimonials
                    .FirstOrDefaultAsync(m => m.Id == id);
                if (post == null)
                {
                    return NotFound();
                }

                return View(post);
            }

            // GET: Admin/Posts/Create
            public IActionResult Create()
            {
                return View();
            }

            // POST: Admin/Posts/Create
            // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
            // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
            [HttpPost]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> Create(IFormFile formImage, Testimonial post)
            {
                if (ModelState.IsValid)
                {
                    if (formImage == null)
                    {
                        ModelState.AddModelError("Image", "Image is required.");
                        return View(post);
                    }
                    var imageName = Guid.NewGuid() + Path.GetExtension(formImage.FileName);

                    if (!Directory.Exists(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/Testimonial")))
                    {
                        Directory.CreateDirectory(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/Testimonial"));
                    }

                    //Get url To Save
                    var savePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/Testimonial", imageName);

                    await using (var stream = new FileStream(savePath, FileMode.Create))
                    {
                        formImage.CopyTo(stream);
                    }

                    post.Photo = $"/img/Testimonial/{imageName}";
                    post.FullName = UrlHelper.GetFriendlyTitle(post.FullName);


                    _context.Add(post);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                return View(post);
            }

            // GET: Admin/Posts/Edit/5
            public async Task<IActionResult> Edit(int? id)
            {
                if (id == null)
                {
                    return NotFound();
                }

                var post = await _context.Testimonials.FindAsync(id);
                if (post == null)
                {
                    return NotFound();
                }
                return View(post);
            }

            // POST: Admin/Posts/Edit/5
            // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
            // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
            [HttpPost]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> Edit(int id, IFormFile image, Testimonial testimonial)
            {
                if (id != testimonial.Id)
                {
                    return NotFound();
                }
                var thisPost = await _context.Testimonials.FirstAsync(p => p.Id == testimonial.Id);

                if (thisPost == null)
                {
                    return NotFound();
                }

                if (!ModelState.IsValid) return View(testimonial);

                if (image != null)
                {
                    //Set Key Name
                    var imageName = Guid.NewGuid() + Path.GetExtension(image.FileName);

                    if (!Directory.Exists(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/Testimonial")))
                    {
                        Directory.CreateDirectory(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/Testimonial"));
                    }

                    //Get url To Save
                    var savePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/Testimonial", imageName);

                    await using (var stream = new FileStream(savePath, FileMode.Create))
                    {
                        image.CopyTo(stream);
                    }

                    thisPost.Photo = $"/img/Testimonial/{imageName}";

                }
                try
                {

                    thisPost.FullName = testimonial.FullName;
                    thisPost.Comment = testimonial.Comment;

                    _context.Update(thisPost);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TestimonialExists(testimonial.Id))
                    {
                        return NotFound();
                    }

                    throw;
                }
                return RedirectToAction(nameof(Index));
            }

            // GET: Admin/Posts/Delete/5
            public async Task<IActionResult> Delete(int? id)
            {
                if (id == null)
                {
                    return NotFound();
                }

                var post = await _context.Testimonials
                    .FirstOrDefaultAsync(m => m.Id == id);
                if (post == null)
                {
                    return NotFound();
                }

                return View(post);
            }

            // POST: Admin/Posts/Delete/5
            [HttpPost, ActionName("Delete")]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> DeleteConfirmed(int id)
            {
                var post = await _context.Testimonials.FindAsync(id);
                _context.Testimonials.Remove(post);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            private bool TestimonialExists(int id)
            {
                return _context.Testimonials.Any(e => e.Id == id);
            }


        }
    }
}
