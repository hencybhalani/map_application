using Microsoft.AspNetCore.Mvc;

namespace map_application.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
