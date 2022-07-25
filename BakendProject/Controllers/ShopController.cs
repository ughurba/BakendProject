using BakendProject.DAL;
using BakendProject.Models;
using BakendProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BakendProject.Controllers
{
    public class ShopController : Controller
    {
        private readonly AppDbContext _context;
        public ShopController(AppDbContext context)
        {
            _context = context;
        }

       
        public IActionResult Index(int page = 1, int take = 5)
        {
           
            List<Product> products = _context.Products.Include(p=>p.ProductImages).Skip((page - 1) * take).Take(take).ToList();
            PaginationVM<Product> pagination = new PaginationVM<Product>(products, PageCount(take), page);
            ViewBag.Pagination = pagination.PageCount;
            ViewBag.CurrentPage = pagination.CurrentPage;
            return View(products);
        }
       
        public IActionResult Sort(int take)
        {
            List<Product> products = _context.Products.Include(p => p.ProductImages).Take(take).ToList();
            return PartialView("_SortPartial",products);
        }
        
        public IActionResult SortMinMax(int min)
        {
            List<Product> dBproducts = _context.Products.Include(p => p.ProductImages).ToList();
            if (min == 2)
            {
                List<Product> products = _context.Products.Include(p => p.ProductImages).OrderBy(p => p.Price).ToList();
                return PartialView("_SortPartial", products);
            }

            return PartialView("_SortPartial", dBproducts);
        }


        //public IActionResult SortTwoPage(int take)
        //{
        //    List<Product> products = _context.Products.Include(p => p.ProductImages).Take(take).ToList();
        //    return PartialView("_SortPartialTwo", products);
        //}


        //public async  Task <IActionResult> SortMinMaxPageTwo(int min)
        //{
        //    List<Product> dBproducts = await _context.Products.Include(p => p.ProductImages).ToListAsync();
        //    if (min == 2)
        //    {
        //        List<Product> products = await _context.Products.Include(p => p.ProductImages).OrderBy(p => p.Price).ToListAsync();
        //        return  PartialView("_SortPartialTwo", products);
        //    }

        //    return PartialView("_SortPartialTwo", dBproducts);
        //}



        private int PageCount(int take)
        {

            List<Product> products = _context.Products.ToList();
            return (int)Math.Ceiling((decimal)products.Count() / take);
        
        }



        public IActionResult Detail(int id)
        {

            List<Product> products = _context.Products.Include(p => p.ProductImages).ToList();
            Product dbProduct = _context.Products.Include(p => p.ProductImages).Include(p => p.Brand).FirstOrDefault(p => p.Id == id);
            DetailVM detail = new DetailVM();
            detail.Products = products;
            detail.Product = dbProduct;
            ViewBag.Description = dbProduct.Desc;
            return View(detail);



        }

        public IActionResult DetailTwo(int? id)
        {

            Product dbProduct = _context.Products.Include(p => p.ProductImages).Include(p=>p.Brand).FirstOrDefault(p => p.Id == id);
            return PartialView("_DetailPartial", dbProduct);

        }
        public IActionResult DescComment(int? id)
        {

            Product dbProduct = _context.Products.Include(p => p.ProductImages).Include(p => p.Brand).FirstOrDefault(p => p.Id == id);
          
            return PartialView("_DescCommetPartial", dbProduct);

        }
    }
}
