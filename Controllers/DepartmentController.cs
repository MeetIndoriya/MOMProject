using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MOMProject.Models;
using System.Data;
using System.Data.SqlClient;

namespace MOMProject.Controllers
{
    public class DepartmentController : Controller
    {

        private IConfiguration configuration;

        public DepartmentController(IConfiguration _configuration)
        {
            configuration = _configuration;
        }
        public IActionResult DepartmentList()
        {
            List<Department> list = new List<Department>();

            string connectionString = configuration.GetConnectionString("ConnectionString");
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "SP_MOM_Staff_SELECTALL";
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Department model = new Department();
                model.DepartmentID = Convert.ToInt32(reader["DepartmentID"]);
                model.DepartmentName = reader["DepartmentName"].ToString();
                model.Created = Convert.ToDateTime(reader["Created"]);
                model.Modified = Convert.ToDateTime(reader["Modified"]);

                list.Add(model);
            }

            connection.Close();
            return View(list);
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
