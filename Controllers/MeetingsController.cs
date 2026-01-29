using Microsoft.AspNetCore.Mvc;

namespace MOMProject.Controllers
{
    public class MeetingsController : Controller
    {
        public IActionResult MeetingsList()
        {
            ViewBag.Title = "Meetings";
            return View();
        }
        public IActionResult MeetingsAddEdit()
        {
            return View();
        }
    }
}
