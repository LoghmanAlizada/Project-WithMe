using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WithMe.DAL;
using WithMe.Models;

namespace WithMe.Controllers
{
    public class BasketController : Controller
    {
        private readonly AppDbContext _context;
        public BasketController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> AddBasket(int? id)
        {
            if (id == null) return NotFound();
            DessertsSectionForThirdMenu dbProduct = await _context.DessertsSectionForThirdMenus.FindAsync(id);
            if (dbProduct == null) return NotFound();
            List<BasketProduct> products;

            string existBasket = Request.Cookies["basket"];
            if (existBasket == null)
            {
                products = new List<BasketProduct>();
            }
            else
            {
                products = JsonConvert.DeserializeObject<List<BasketProduct>>(Request.Cookies["basket"]);

                var existBasketProduct = products.Find(d => d.Id == dbProduct.Id);
                if (existBasketProduct == null)
                {
                    BasketProduct basketProduct = new BasketProduct();
                    basketProduct.Id = dbProduct.Id;
                    basketProduct.Name = dbProduct.Name;
                    basketProduct.Price = dbProduct.Price;
                    basketProduct.ImageURL = dbProduct.ImageURL;
                    basketProduct.Count = 1;

                    products.Add(basketProduct);
                }
                else
                {
                    existBasketProduct.Count++;
                }
            }
             
            Response.Cookies.Append("basket", JsonConvert.SerializeObject(products), new CookieOptions { MaxAge = TimeSpan.FromMinutes(120) });



            return RedirectToAction("Index", "ThirdMenu");
        }

        public IActionResult Basket()
        {
            List<BasketProduct> products = JsonConvert.DeserializeObject<List<BasketProduct>>(Request.Cookies["basket"]);
            return View(products);
        }

        public IActionResult RemoveItem(int? id)
        {
            if (id == null) NotFound();
            string basket = Request.Cookies["basket"];
            List<BasketProduct> products = JsonConvert.DeserializeObject<List<BasketProduct>>(basket);

            BasketProduct existProduct = products.FirstOrDefault(p => p.Id == id);

            if (existProduct == null) return NotFound();

            products.Remove(existProduct);

            Response.Cookies.Append("basket", JsonConvert.SerializeObject(products), new CookieOptions { MaxAge = TimeSpan.FromMinutes(120)});

            return RedirectToAction("basket", "Basket");
        }

        public IActionResult Minus(int? id)
        {
            if (id == null) NotFound();
            string basket = Request.Cookies["basket"];
            List<BasketProduct> products = JsonConvert.DeserializeObject<List<BasketProduct>>(basket);

            BasketProduct existProduct = products.FirstOrDefault(p => p.Id == id);

            if (existProduct == null) return NotFound();

            if (existProduct.Count > 1)
            {
                existProduct.Count--;
            }
            else
            {
                RemoveItem(existProduct.Id);
                return RedirectToAction("basket", "Basket");
            }

            Response.Cookies.Append("basket", JsonConvert.SerializeObject(products), new CookieOptions { MaxAge = TimeSpan.FromMinutes(120) });

            return RedirectToAction("basket", "Basket");
        }

        public IActionResult Plus(int? id)
        {
            if (id == null) NotFound();
            string basket = Request.Cookies["basket"];
            List<BasketProduct> products = JsonConvert.DeserializeObject<List<BasketProduct>>(basket);

            BasketProduct existProduct = products.FirstOrDefault(p => p.Id == id);

            if (existProduct == null) return NotFound();

            existProduct.Count++;

            Response.Cookies.Append("basket", JsonConvert.SerializeObject(products), new CookieOptions { MaxAge = TimeSpan.FromMinutes(120) });

            return RedirectToAction("basket", "Basket");
        }
    }
}
