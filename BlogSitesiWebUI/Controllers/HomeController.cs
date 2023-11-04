using BlogSistemi.Service.Services;
using BlogSitesiWebUI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BlogSitesiWebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IPostService postService;

        public HomeController(ILogger<HomeController> logger,IPostService postService)
        {
            _logger = logger;
            this.postService = postService;
        }

        public async Task<IActionResult> Index()
        {
            var posts = await postService.GetAllPostsAsync();

            return View(posts);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}