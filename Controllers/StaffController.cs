using Microsoft.AspNetCore.Mvc;

namespace MOMProject.Controllers
{
    public class StaffController : Controller
    {
        public IActionResult StaffList()
        {
            ViewBag.Title = "Meeting Staff";
            return View();
        }
        public IActionResult StaffAddEdit()
        {
            return View();
        }

    }
}
