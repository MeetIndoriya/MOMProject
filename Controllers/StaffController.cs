using Microsoft.AspNetCore.Mvc;
using MOMProject.Models;

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
        [HttpPost]
        public IActionResult StaffAddEdit(Staff model)
        {
            if (!ModelState.IsValid)
                return View(model);

            return View("StaffList"); 
        }
    }
}
