﻿using Microsoft.AspNetCore.Mvc;

namespace BlogSitesiWebUI.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
