using Microsoft.AspNetCore.Mvc;
using MOMProject.Models;

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
        [HttpPost]
        public IActionResult MeetingVenueAddEdit(MeetingVenue model)
        {
            if (!ModelState.IsValid)
                return View(model); 

            return View("MeetingVenueList"); 
        }
    }
}
