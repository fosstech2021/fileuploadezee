using System.Security.Claims;
using System.Threading.Tasks;
using BasePackageModule1.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BasePackageModule1.ViewComponents
{
    [ViewComponent(Name = "UserName")]
    public class UserName:ViewComponent
    {
        private readonly ApplicationDbContext _context;
        public UserName(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var claims = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);

            var userFromDb = await _context.ApplicationUser.FirstOrDefaultAsync(u => u.Id == claims.Value);
            return View(userFromDb);
        }

    }
}
