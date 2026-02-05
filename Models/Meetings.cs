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

        public int MeetingVenueID { get; set; }

        public int MeetingTypeID { get; set; }
        public int DepartmentID { get; set; }
        public string? MeetingVenue { get; set; }
        [Required(ErrorMessage = "Meeting Venue is required")]
        public string? MeetingDescription { get; set; }

        public string? DocumentPath { get; set; }

        public DateTime Created { get; set; }

        public DateTime Modified { get; set; }

        public int IsCancelled { get; set; }

        public DateTime CancellationDateTime { get; set; }

        public string? CancellationReason { get; set; }

        [Required(ErrorMessage = "Meeting Type is required")]
        public string? MeetingType { get; set; } 

        [Required(ErrorMessage = "Department is required")]
        public string? DepartmentName { get; set; } 

        public string? Remarks { get; set; } 


    }
}
