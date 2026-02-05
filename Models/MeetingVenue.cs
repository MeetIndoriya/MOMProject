using System.ComponentModel.DataAnnotations;

namespace MOMProject.Models
{
    public class MeetingVenue
    {
        public int MeetingVenueID { get; set; }

        [Required(ErrorMessage = "Meeting Venue Name is required")]
        [StringLength(100, ErrorMessage = "Venue name cannot exceed 100 characters")]
        public string? MeetingVenueName { get; set; }

        public DateTime Created { get; set; }

        public DateTime Modified { get; set; }
    }
}
