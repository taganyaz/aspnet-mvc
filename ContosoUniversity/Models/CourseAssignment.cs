namespace ContosoUniversity.Models;

public class CourseAssignment
{
    public int CourseId { get; set; }
    public int InstructorId { get; set; }
    public Course Course { get; set; } = default!;
    public Instructor Instructor { get; set; } = default!;
}
