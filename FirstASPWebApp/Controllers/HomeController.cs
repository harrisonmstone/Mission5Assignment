using Microsoft.AspNetCore.Mvc;

namespace FirstASPWebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Hobby()
        {
            return View();
        }
    }
}
