﻿using BacolaFrontBackDatabase.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BacolaFrontBackDatabase.Controllers
{
    public class ShopController : Controller
    {
        private readonly BacolaFrontBackDatabaseContext _context;

        public ShopController(BacolaFrontBackDatabaseContext context)
        {
            _context = context;
        }

        // GET: Products
        public async Task<IActionResult> Index()
        {
            ViewBag.Title = "Shop";
            ViewBag.Javascript = "shop";
            return View(await _context.Product.ToListAsync());
        }

        // GET: Products/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Product
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }
    }
}
