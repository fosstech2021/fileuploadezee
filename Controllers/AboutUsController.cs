using System.Linq;
using System.Threading.Tasks;
using BasePackageModule1.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace BasePackageModule1.Controllers
{
    public class AboutUsController : Controller
    {
        private readonly ILogger<AboutUsController> _logger;
        private readonly ApplicationDbContext _context;

       

        public AboutUsController(ILogger<AboutUsController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;

        }
        public async Task<IActionResult> Index()
        {
            var about = new Models.AboutUs();

            if (_context.AboutUs.Any())
            {
                about = _context.AboutUs.FirstOrDefault();

            }
            return View(about);
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var footer = await _context.AboutUs
                .FirstOrDefaultAsync(m => m.AboutUsId == id);
            if (footer == null)
            {
                return NotFound();
            }

            return View(footer);
        }
    }
}