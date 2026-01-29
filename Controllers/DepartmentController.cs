using Microsoft.AspNetCore.Mvc;
using MOMProject.Models;

namespace MOMProject.Controllers
{
    public class DepartmentController : Controller
    {
        public IActionResult DepartmentList()
        {
            ViewBag.Title = "Department";
            Department department = new Department();
            department.DeptId = 101;
            department.DeptName = "Computer";
            department.Hod = "Dr. Alex Johnson";
            department.Location = "Building A, Level 3";
            return View(department);
        }
        public IActionResult DepartmentAddEdit()
        {
            return View();
        }
    }
}
