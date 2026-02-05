using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MOMProject.Models;

namespace MOMProject.Controllers
{
    public class MeetingsController : Controller
    {

        private IConfiguration configuration;

        public MeetingsController(IConfiguration _configuration)
        {
            configuration = _configuration;
        }

        public IActionResult MeetingsList()
        {
            ViewBag.Title = "Meetings";
            return View();
        }
        public IActionResult MeetingsAddEdit()
        {
            return View();
        }
        [HttpPost]
        public IActionResult MeetingsAddEdit(Meeting model)
        {
            if (!ModelState.IsValid)
                return View(model);  

            return View("MeetingsList"); 
        }
    }
}
