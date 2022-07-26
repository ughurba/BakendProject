using BakendProject.DAL;
using BakendProject.Models;
using BakendProject.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BakendProject.ViewComponents
{
    public class HeaderViewComponent : ViewComponent
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;
        public HeaderViewComponent(AppDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager; 
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<Bio> dbBio = _context.Bios.ToList();

            List<Category> dbCategories = _context.Categories.Where(c => c.ParentId == null).ToList();
            List<Category> dbSubCategories = _context.Categories.OrderBy(c => c.ParentId == c.Id).ToList();
            ViewBag.User = "";
            if (User.Identity.IsAuthenticated)
            {
                AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
                ViewBag.User = user.Name;

            }
           



            HeaderVM headerVM = new HeaderVM();
            headerVM.bios = dbBio;
            headerVM.categories = dbCategories;
            headerVM.subCategories = dbSubCategories;
   
           


            return View(await Task.FromResult(headerVM));
        }
    }
}
