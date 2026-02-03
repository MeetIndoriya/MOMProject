using Microsoft.AspNetCore.Mvc;
using MOMProject.Models;

public class MeetingMemberController : Controller
{
    public IActionResult MeetingMemberList()
    {
        return View();
    }

    public IActionResult MeetingMemberAddEdit() 
    {
        return View();
    }

    [HttpPost]
    public IActionResult MeetingMemberAddEdit(MeetingMember model)
    {
        if (!ModelState.IsValid)
            return View(model); 

        return View("MeetingMemberList");  
    }
}
