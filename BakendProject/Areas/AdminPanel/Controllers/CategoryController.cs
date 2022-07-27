using BakendProject.DAL;
using BakendProject.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BakendProject.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class CategoryController : Controller
    {
        private readonly AppDbContext _context;

        public DateTime? Date { get; private set; }

        public CategoryController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Category> categories = _context.Categories.ToList();
            return View(categories);
        }
        public IActionResult Create()
        {
            return View();

        }
        [HttpPost]
        public async Task<IActionResult> Create(Category category)
        {

            if (!ModelState.IsValid)
            {
                return View();

            }
            bool existNNameCtegory = _context.Categories.Any(x => x.Name.ToLower() == category.Name.ToLower());
            if (existNNameCtegory)
            {
                ModelState.AddModelError("Name", "Bu adli category Var");
            }
            Category newCategory = new Category
            {
                Name = category.Name,
                ParentId = category.ParentId,
                CreatedAt = DateTime.Now


            };

            await _context.Categories.AddAsync(newCategory);
            await _context.SaveChangesAsync();
            return RedirectToAction("index");

        }
        public async Task<IActionResult> Detail(int? id)

        {
            if (id == null) return NotFound();
            Category category = await _context.Categories.FindAsync(id);
            if (category == null) return NotFound();
            return View(category);
        }
        public async Task<IActionResult> Update(int? id)

        {
            if (id == null) return NotFound();
            Category category = await _context.Categories.FindAsync(id);
            if (category == null) return NotFound();
            return View(category);
        }
        [HttpPost]
        public async Task<IActionResult> Update(Category category)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            Category dbCategory = _context.Categories.FirstOrDefault(c => c.Id == category.Id);
            Category dbCategoryName = _context.Categories.FirstOrDefault(c => c.Name.ToLower() == category.Name.ToLower());
            if (dbCategoryName != null)
            {
                if (dbCategoryName.Name != dbCategory.Name)
                {
                    ModelState.AddModelError("Name", "bu adli category var");
                    return View();
                }
            }

            dbCategory.ParentId = category.ParentId;
            dbCategory.Name = category.Name;
        
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        //public IActionResult Delete(int? id)
        //{
        //    Category dbCategory = _context.Categories.FirstOrDefault(c => c.Id == id);
        //    if (dbCategory == null) return View();
        //    _context.Categories.Remove(dbCategory);
        //    _context.SaveChanges();
        //    return RedirectToAction("index");
        //}
    }
}
