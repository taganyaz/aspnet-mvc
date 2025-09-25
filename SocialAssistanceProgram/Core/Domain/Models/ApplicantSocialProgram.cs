using System.ComponentModel.DataAnnotations;

namespace SocialAssistanceProgram.Core.Domain.Models;

public class ApplicantSocialProgram
{
    [Required(ErrorMessage = "Applicant is required")]
    public int ApplicantId { get; set; }
    public Applicant Applicant { get; set; } = null!;

    [Required(ErrorMessage = "Social program is required")]
    public int SocialProgramId { get; set; }
    public SocialProgram SocialProgram { get; set; } = null!;
}