using Microsoft.AspNetCore.Mvc;

namespace MOMProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
