using Microsoft.AspNetCore.Mvc;

namespace MOMProject.Controllers
{
    public class MeetingVenueController : Controller
    {
        public IActionResult MeetingVenueList()
        {
            ViewBag.Title = "Meeting Venue";
            return View();
        }
        public IActionResult MeetingVenueAddEdit()
        {
            return View();
        }
    }
}
