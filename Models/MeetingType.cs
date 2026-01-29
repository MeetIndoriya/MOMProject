using MOMProject.Models;
using System.ComponentModel.DataAnnotations;

public class MeetingType
{
    [Required(ErrorMessage = "Meeting Type is Required")]
    [Display(Name = "MeetingType")]
    public string Meetingtype { get; set; }

    [Display(Name = "Remarks")]
    public string Remarks { get; set; }
}