using System.ComponentModel.DataAnnotations;

namespace MOMProject.Models
{
    public class Staff
    {
        public int StaffID { get; set; }

        [Required(ErrorMessage = "Staff Name is required")]
        [StringLength(100, ErrorMessage = "Staff name cannot exceed 100 characters")]
        public string? StaffName { get; set; }

        [Required(ErrorMessage = "Department is required")]
        public string? DepartmentName { get; set; }
    }
}
