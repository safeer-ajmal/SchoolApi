
namespace School.Domain.Entities;
public class Student : User
{
    public string RollNumber { get; set; }
    public Guid ClassId { get; set; }
    public Class Class { get; set; }
    public ICollection<Attendance> Attendances { get; set; }
    public ICollection<Grade> Grades { get; set; }
}