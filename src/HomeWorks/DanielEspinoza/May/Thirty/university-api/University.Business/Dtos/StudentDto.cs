namespace University.Business.Dtos;

public class StudentDto
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public required string LastName { get; set; }
    public DateTime BirthDate { get; set; }
}