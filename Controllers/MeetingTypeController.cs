using Microsoft.AspNetCore.Mvc;

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
        public IActionResult Create(MeetingType model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Message = "Meeting Type Registered Successfully";
                //return View("Success");
            }
            return View("MeetingTypeList",model);
        }

    }
}
