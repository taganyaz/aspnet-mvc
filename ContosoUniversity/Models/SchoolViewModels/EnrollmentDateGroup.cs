using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.Models.SchoolViewModels;

public class EnrollmentDateGroup
{
    [DataType(DataType.Date)]
    public DateOnly? EnrollmentDate { get; set; }
    public int StudentCount { get; set; }
}
