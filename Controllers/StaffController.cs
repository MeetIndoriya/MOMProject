using Microsoft.AspNetCore.Mvc;
using MOMProject.Models;
using System.Data;
using System.Data.SqlClient;

namespace MOMProject.Controllers
{
    public class StaffController : Controller
    {
        private IConfiguration configuration;

        public StaffController(IConfiguration _configuration)
        {
            configuration = _configuration;
        }

        public IActionResult StaffList()
        {
            List<Staff> list = new List<Staff>();

            string connectionString = configuration.GetConnectionString("ConnectionString");
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "SP_MOM_Staff_SELECTALL";
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Staff model = new Staff();
                model.StaffID = Convert.ToInt32(reader["StaffID"]);
                model.StaffName = reader["StaffName"].ToString();
                model.Created = Convert.ToDateTime(reader["Created"]);
                model.Modified = Convert.ToDateTime(reader["Modified"]);
                list.Add(model);
            }

            connection.Close();
            return View(list);
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
