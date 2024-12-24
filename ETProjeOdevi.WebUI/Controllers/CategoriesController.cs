﻿using Et.Core.Entities;
using Et.Data;
using Et.Service.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ETProjeOdevi.WebUI.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly IService<Category> _service;


        public CategoriesController(IService<Category> service)
        {
            _service = service;
        }
        public async Task<IActionResult> IndexAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = await _service.GetQueryable(). Include(p => p.Products)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }
    }
}
