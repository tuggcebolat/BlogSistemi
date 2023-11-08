using Microsoft.AspNetCore.Mvc;

namespace BlogSitesiWebUI.Areas.Admin
{
    public class AuthController : Controller
    {

        public AuthController()
        {
                
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
