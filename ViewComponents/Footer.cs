using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BasePackageModule1.Data;
using BasePackageModule1.Models;
using BasePackageModule1.Models.Menu;
using BasePackageModule1.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BasePackageModule1.ViewComponents
{
    [ViewComponent(Name = "Footer")]
    public class Footer : ViewComponent
    {
        private readonly ApplicationDbContext _context;

        public Footer(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var logo = await _context.Logos.AnyAsync()
                ? await _context.Logos.FirstOrDefaultAsync()
                : new Logo();


            var businessProfile = await _context.BusinessProfile.AnyAsync()
                ? await _context.BusinessProfile.FirstOrDefaultAsync()
                : new BusinessProfile();


            List<Page> page = await _context.Pages.OrderBy(o => o.Order).ToListAsync();
            var categories = await _context.Categories.Include(s => s.SubCategories).OrderByDescending(k => k.SubCategories.Count).ToListAsync();
            var products = await _context.Products.ToListAsync();

            List<Menu> menus = await _context.Menus.Include(m => m.MenuProducts).ThenInclude(p => p.Product).OrderBy(o => o.Order).ToListAsync();


            NavViewModel model = new NavViewModel
            {
                Menus = menus,
                Logo = logo,
                More = page,
                Categories = categories,
                BusinessProfile = businessProfile,
                Products = products
            };

            return View("Index", model);
        }
    }
}