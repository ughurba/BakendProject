using BakendProject.DAL;
using BakendProject.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace BakendProject.Controllers
{

    public class BasketController : Controller
    {

        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;
        public BasketController(AppDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddItem([FromForm] int? id)
        {
            Product dbProduct = _context.Products.Include(p => p.ProductImages).FirstOrDefault(p => p.Id == id);
            ProductImage productImage = dbProduct.ProductImages.FirstOrDefault(p => p.ProductId == id && p.IsMain);
            BasketItem basketItem = new BasketItem();
          
            if (User.Identity.IsAuthenticated)
            {

                AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
                BasketItem isExist = _context.BasketItems.FirstOrDefault(b => b.ProductId == dbProduct.Id);
                if (isExist == null)
                {

                    basketItem.ProductId = dbProduct.Id;
                    basketItem.Price = dbProduct.Price;
                    basketItem.AppUser = user;
                    basketItem.AppUserId = user.Id;
                    basketItem.Product = dbProduct;
                    basketItem.Count = 1;
                    basketItem.ImgUrl = productImage.ImageUrl;
                    await _context.AddAsync(basketItem);
                }
                else
                {
                    isExist.Count++;
                 
                }

                
                await _context.SaveChangesAsync();

            }

            return RedirectToAction("index", "home");
        }
    }
}
