using System.ComponentModel.DataAnnotations;

namespace MOMProject.Models
{
    public class Staff
    {
        public int StaffID { get; set; }

        [Required(ErrorMessage = "Staff Name is required")]
        [StringLength(100, ErrorMessage = "Staff name cannot exceed 100 characters")]
        public string StaffName { get; set; }

        public DateTime Created { get; set; }

        public DateTime Modified { get; set; }

        [Required(ErrorMessage = "Department is required")]
        public string? DepartmentName { get; set; }

        public int DepartmentID { get; set; }

        public string MobileNo { get; set; }
        public string EmailAddress { get; set; }
        public string Remarks { get; set; }


    }
}
