using Microsoft.AspNetCore.Mvc;
using MOMProject.Models;

public class MeetingMemberController : Controller
{
    private IConfiguration configuration;

    public MeetingMemberController(IConfiguration _configuration)
    {
        configuration = _configuration;
    }
    public IActionResult MeetingMemberList()
    {
        SP_MOM_MeetingMember_SELECTALL
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
