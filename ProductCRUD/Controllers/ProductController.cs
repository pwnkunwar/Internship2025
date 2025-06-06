﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductCRUD.Database;
using ProductCRUD.Models;

namespace ProductCRUD.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _db;
        public ProductController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Product> products = _db.Products.ToList(); 
            return View(products);

        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateAsync(Product product)
        {
            if (ModelState.IsValid)
            {
                await _db.Products.AddAsync(product);
                await _db.SaveChangesAsync();
                TempData["Message"] = "Product Created Successfully!";
                TempData["MessageType"] = "success";
                return RedirectToAction("Index");
            }
            return View(product);
        }
        [HttpGet]
        public async Task<IActionResult> EditAsync(Guid productId)
        {
            var findProduct = await _db.Products.FindAsync(productId);
            if(findProduct == null)
            {
                return NotFound();
            }
            Product product = await _db.Products.FirstOrDefaultAsync(p=>p.ProductId == productId);
            return View(product);
        }
        [HttpPost]
        public async Task<IActionResult> EditAsync(Product product)
        {
            if(ModelState.IsValid)
			{
				_db.Products.Update(product);
				await _db.SaveChangesAsync();
                TempData["Message"] = "Product Edited Successfully!";
                TempData["MessageType"] = "success";
                return RedirectToAction("Index");
			}
			return View(product);
        }
        [HttpGet]
        public async Task<IActionResult> DeleteAsync(Guid productId)
		{
			var findProduct = await _db.Products.FindAsync(productId);
			if(findProduct == null)
			{
				return NotFound();
			}
			Product product = await _db.Products.FirstOrDefaultAsync(p=>p.ProductId == productId);
			return View(product);
		}
        [HttpPost]
        public async Task<IActionResult> DeleteAsync(Product product)
        {
             _db.Products.Remove(product);
            await _db.SaveChangesAsync();
            TempData["Message"] = "Product Deleted Successfully!";
            TempData["MessageType"] = "error";
            return RedirectToAction("Index");
            
        }

    }
}
