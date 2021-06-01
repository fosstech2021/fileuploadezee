using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BasePackageModule1.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BasePackageModule1.Controllers
{
    public class DoctorsController : Controller
    {
        private readonly ApplicationDbContext _context;
        public DoctorsController(ApplicationDbContext context )
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {

            return View(await _context.Doctors.OrderByDescending(d=>d.Id).ToListAsync());
        }


        // GET: Members/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var member = await _context.Doctors
                .FirstOrDefaultAsync(m => m.Id == id);
            if (member == null)
            {
                return NotFound();
            }

            return View(member);
        }
    }
}
