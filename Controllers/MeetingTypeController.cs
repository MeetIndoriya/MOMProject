using Microsoft.AspNetCore.Mvc;
using MOMProject.Models;

namespace MOMProject.Controllers
{
    public class MeetingTypeController : Controller
    {
        public IActionResult MeetingTypeList()
        {
            ViewBag.Title = "Meeting Type";
            return View();
        }

        public IActionResult MeetingTypeAddEdit()
        {
            return View();
        }

        [HttpPost]
        public IActionResult MeetingTypeAddEdit(MeetingType model)
        {
            if (!ModelState.IsValid)
                return View(model);  

            return View("MeetingTypeList");
        }

    }
}
