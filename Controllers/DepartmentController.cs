using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MOMProject.Models;
using System.Data;
using System.Data.SqlClient;

namespace MOMProject.Controllers
{
    public class DepartmentController : Controller
    {

        public IActionResult DepartmentList()
        {
            return View();
        }
        public IActionResult DepartmentAddEdit()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DepartmentAddEdit(Department model)
        {
            if (!ModelState.IsValid)
                return View(model);

            return View("DepartmentList"); 
        }
    }
}
