using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models;

public class Department
{
    public int DepartmentId { get; set; }

    [StringLength(50, MinimumLength = 3)]
    [Required]
    public string Name { get; set; } = string.Empty;

    [DataType(DataType.Currency)]
    [Column(TypeName = "money")]
    public decimal Budget { get; set; }

    [DataType(DataType.Date)]
    [Display(Name = "Start Date")]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    public DateOnly StartDate { get; set; }

    public int? InstructorId { get; set; }

    [Timestamp]
    public byte[] RowVersion { get; set; }
    public Instructor? Administrator { get; set; }

    public ICollection<Course> Courses { get; set; } = new List<Course>();
}
