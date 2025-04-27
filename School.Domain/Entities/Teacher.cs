
namespace School.Domain.Entities;
public class Teacher : User
{
public string SubjectSpecialization { get; set; }
public ICollection<Class> Classes { get; set; } // Many-to-Many (later)
}