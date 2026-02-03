using System.ComponentModel.DataAnnotations;
namespace MOMProject.Models
{
    public class Meeting
    {
        public int MeetingID { get; set; }

        [Required(ErrorMessage = "Meeting Name is required")]
        [StringLength(100, ErrorMessage = "Meeting name cannot exceed 100 characters")]
        public string? MeetingName { get; set; } 

        [Required(ErrorMessage = "Meeting Date is required")]
        [DataType(DataType.Date)]
        public DateTime MeetingDate { get; set; }

        [Required(ErrorMessage = "Meeting Venue is required")]
        public string? MeetingVenue { get; set; } 

        [Required(ErrorMessage = "Meeting Type is required")]
        public string? MeetingType { get; set; } 

        [Required(ErrorMessage = "Department is required")]
        public string? DepartmentName { get; set; } 

        public string? Remarks { get; set; } 
    }
}
