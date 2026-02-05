using System.ComponentModel.DataAnnotations;

namespace MOMProject.Models
{
    public class Department
    {
        public int DepartmentID { get; set; }

        [Required(ErrorMessage = "Department Name is required")]
        [StringLength(100, ErrorMessage = "Department name cannot exceed 100 characters")]
        public string? DepartmentName { get; set; }
        
        public DateTime Created { get; set; }

        public DateTime Modified { get; set; }
    }
}
