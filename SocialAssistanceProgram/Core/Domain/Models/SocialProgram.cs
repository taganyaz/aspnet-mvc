using System.ComponentModel.DataAnnotations;

namespace SocialAssistanceProgram.Core.Domain.Models;

public class SocialProgram
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "Program name is required")]
    [StringLength(100, ErrorMessage = "Program name cannot exceed 100 characters")]
    [Display(Name = "Program Name")]
    public string Name { get; set; } = string.Empty;

    [StringLength(500, ErrorMessage = "Description cannot exceed 500 characters")]
    [Display(Name = "Description")]
    public string? Description { get; set; }
}
