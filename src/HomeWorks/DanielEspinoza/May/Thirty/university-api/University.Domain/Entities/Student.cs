namespace University.Domain;

public class Student: IEntityBase
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public required string LastName { get; set; }
    public DateTime BirthDate { get; set; }
    public ICollection<Career> Careers { get; set; } = [];
}
