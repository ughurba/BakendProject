using BakendProject.DAL;
using BakendProject.Models;
using BakendProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BakendProject.ViewComponents
{
    public class HeaderViewComponent : ViewComponent
    {
        private readonly AppDbContext _context;
        public HeaderViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<Bio> dbBio = _context.Bios.ToList();

            List<Category> dbCategories = _context.Categories.Where(c => c.ParentId == null).ToList();
            List<Category> dbSubCategories = _context.Categories.OrderBy(c => c.ParentId == c.Id).ToList();
            



            HeaderVM headerVM = new HeaderVM();
            headerVM.bios = dbBio;
            headerVM.categories = dbCategories;
            headerVM.subCategories = dbSubCategories;


            return View(await Task.FromResult(headerVM));
        }
    }
}
