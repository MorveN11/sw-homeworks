namespace Project.Business.DTOs.Student;

public class StudentDTO
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }
}