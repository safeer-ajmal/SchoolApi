namespace School.Domain.Entities;
public class Class
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Section { get; set; }
    public Guid? TeacherId { get; set; }
    public Teacher? Teacher { get; set; }
    public ICollection<Student> Students { get; set; }
    public ICollection<Subject> Subjects { get; set; }
}