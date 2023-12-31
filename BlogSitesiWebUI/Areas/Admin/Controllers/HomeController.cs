﻿using BlogSistemi.Service.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BlogSitesiWebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class HomeController : Controller
    {
        private readonly IPostService postService;
        public HomeController(IPostService postService)
        {
            this.postService = postService;
        }
        public async Task<IActionResult> Index()
        {
            var posts = await postService.GetAllPostsAsync();
            return View(posts);
        }
    }
}
