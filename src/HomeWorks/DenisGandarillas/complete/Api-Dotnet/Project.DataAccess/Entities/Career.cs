public class Career: IEntityBase
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Code { get; set; }
    public List<Student> Students { get; set; } = [];
}
