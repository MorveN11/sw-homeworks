namespace University.Domain;


public class Career: IEntityBase
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public required string Code { get; set; }
    public ICollection<Student> Students { get; set; } = [];
}
