using Microsoft.AspNetCore.Mvc;

namespace BlogSitesiWebUI.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
