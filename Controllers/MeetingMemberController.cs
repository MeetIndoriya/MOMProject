using Microsoft.AspNetCore.Mvc;

namespace MOMProject.Controllers
{
    public class MeetingMemberController : Controller
    {
        public IActionResult MeetingMemberList()
        {
            ViewBag.Title = "Meeting Member";
            return View();
        }
        public IActionResult MeetingMemberAddEdit()
        {
            return View();
        }
    }
}
