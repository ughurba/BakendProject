﻿using BakendProject.DAL;
using BakendProject.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
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
        public async Task<IActionResult> Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);

                List<BasketItem> baskets = _context.BasketItems
                    .Include(b => b.Product)
                    .Include(u => u.AppUser)
                    .Where(b => b.AppUserId == user.Id)
                    .ToList();
                return View(baskets);
            }
            else
            {
                return RedirectToAction("login", "account");
            }


        }

        public async Task<IActionResult> AddItem(int? id)
        {
            double total = 0;
            var obj = new object();
            Product dbProduct = _context.Products.Include(p => p.ProductImages).FirstOrDefault(p => p.Id == id);
            ProductImage productImage = dbProduct.ProductImages.FirstOrDefault(p => p.ProductId == id && p.IsMain);
            BasketItem basketItem = new BasketItem();
          
            if (User.Identity.IsAuthenticated)
            {

                AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
                BasketItem isExist = _context.BasketItems.Include(b => b.Product).FirstOrDefault(b => b.ProductId == dbProduct.Id && b.AppUserId == user.Id);
                if (isExist == null)
                {

                    basketItem.ProductId = dbProduct.Id;
                    basketItem.Price = dbProduct.Price;
                    basketItem.AppUser = user;
                    basketItem.AppUserId = user.Id;
                    basketItem.Product = dbProduct;
                    basketItem.Count = 1;
                    basketItem.ImgUrl = productImage.ImageUrl;
                    basketItem.Sum = basketItem.Count * dbProduct.Price;

                    await _context.AddAsync(basketItem);
                   

                }
                else
                {
                    if (isExist.Count <= isExist.Product.StockCount)
                    {
                        isExist.Count++;
                        isExist.Sum = isExist.Count * isExist.Price;
                    }

                }


                await _context.SaveChangesAsync();
                List<BasketItem> basketItems = _context.BasketItems.Where(b => b.AppUserId == user.Id).ToList();



                foreach (var item in basketItems)
                {
                    total += item.Sum;
                }
                obj = new
                {
                    Total = total,  
                    Count = basketItems.Count(),
                    ImgUrl = basketItem.ImgUrl,
                    Name = basketItem.Product.Name,
                    ProductCount = basketItem.Count,
                    Price = basketItem.Price,
                };

            }


            return Json(obj);
        }


        public async Task<IActionResult> Plus(int? id)
        {
            Product dbProduct = _context.Products.Include(p => p.ProductImages).FirstOrDefault(p => p.Id == id);


            var obj = new object();
            if (User.Identity.IsAuthenticated)
            {
                AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);

                BasketItem isExist = _context.BasketItems.Include(p => p.Product).FirstOrDefault(b => b.ProductId == dbProduct.Id && b.AppUserId == user.Id);
                if (isExist != null)
                {
                    if (isExist.Count < isExist.Product.StockCount)
                    {
                        isExist.Count++;
                        isExist.Sum = isExist.Count * isExist.Price;
                        obj = new
                        {
                            Sum = isExist.Sum,
                            Count = isExist.Count,
                            ProductCount = isExist.Product.StockCount

                        };
                    }
                }
                await _context.SaveChangesAsync();
                List<BasketItem> basketItems = _context.BasketItems.Where(b => b.AppUserId == user.Id).ToList();



            }

            return Json(obj);
        }
        public async Task<IActionResult> Minus(int? id)
        {

            Product dbProduct = _context.Products.Include(p => p.ProductImages).FirstOrDefault(p => p.Id == id);


            var obj = new object();
            if (User.Identity.IsAuthenticated)
            {
                AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);

                BasketItem isExist = _context.BasketItems.Include(p => p.Product).FirstOrDefault(b => b.ProductId == dbProduct.Id && b.AppUserId == user.Id);
                if (isExist != null)
                {
                    if (isExist.Count > 1)
                    {
                        isExist.Count--;
                        isExist.Sum = isExist.Count * isExist.Price;
                        obj = new
                        {
                            Sum = isExist.Sum,
                            Count = isExist.Count,
                            ProductCount = isExist.Product.StockCount
                        };
                    }
                }
                await _context.SaveChangesAsync();
            }

            return Json(obj);

        }

        public async Task<IActionResult> Remove(int? id)
        {
            Product dbProduct = _context.Products.Include(p => p.ProductImages).FirstOrDefault(p => p.Id == id);



            if (User.Identity.IsAuthenticated)
            {
                AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);

                BasketItem isExist = _context.BasketItems.Include(p => p.Product).FirstOrDefault(b => b.ProductId == dbProduct.Id && b.AppUserId == user.Id);
                if (isExist != null)
                {
                    _context.BasketItems.Remove(isExist);

                }
                await _context.SaveChangesAsync();
            }
            return Ok();
        }
    }
}
