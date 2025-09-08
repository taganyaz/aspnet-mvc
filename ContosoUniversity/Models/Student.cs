using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.Models;

public class Student
{
    public int Id { get; set; }

    [StringLength(50)]
    [Display(Name = "Last Name")]
    [Required]
    public string LastName { get; set; } = string.Empty;


    [StringLength(50)]
    [Display(Name = "First Name")]
    [Required]
    public string FirstName { get; set; } = string.Empty;

    [DataType(DataType.Date)]
    [Display(Name = "Enrollment Date")]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    public DateOnly EnrollmentDate { get; set; }

    [Display(Name = "Full Name")]
    public string FullName => LastName + ", " + FirstName;
    public ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
}
