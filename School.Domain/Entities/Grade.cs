namespace School.Domain.Entities;
public class Grade
{
    public Guid Id { get; set; }
    public float Marks { get; set; }
    public Guid StudentId { get; set; }
    public Student Student { get; set; }
    public Guid SubjectId { get; set; }
    public Subject Subject { get; set; }
}