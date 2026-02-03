using System.ComponentModel.DataAnnotations;

namespace MOMProject.Models
{
    public class MeetingType
    {
        public int MeetingTypeID { get; set; }

        [Required(ErrorMessage = "Meeting Type is required")]
        [StringLength(50, ErrorMessage = "Type name cannot exceed 50 characters")]
        public string? MeetingTypeName { get; set; }

        [StringLength(500)]
        public string? Remarks { get; set; }
    }
}
