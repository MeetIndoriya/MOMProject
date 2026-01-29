using System.ComponentModel.DataAnnotations;

namespace MOMProject.Models
{
    public class Department
    {
        public int DeptId { get; set; }

        [Required]
        public string DeptName { get; set; }

        [Required]
        public string Hod { get; set; }

        public string Location { get; set; }
    }
}
