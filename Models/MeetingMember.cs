using System.ComponentModel.DataAnnotations;

namespace MOMProject.Models;
public class MeetingMember
{
    public int MeetingMemberID { get; set; }

    [Required(ErrorMessage = "Member Name is required")]
    [StringLength(50, ErrorMessage = "Name cannot exceed 50 characters")]
    public string? MeetingMemberName { get; set; }

    [StringLength(500)]
    public string? Remarks { get; set; }

    public int MeetingId { get; set; }
    public int StaffID { get; set; }

    public int IsPresent { get; set; }

    public string? Created { get; set; }

    public string? Modified { get; set; }
}
