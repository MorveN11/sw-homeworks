namespace _25may24.Entities
{

  public class Subject : IEntityBase
  {

    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Code { get; set; }
    public int Credit { get; set; }

    public ICollection<Have> Haves { get; set; }
    public ICollection<Study> Studies { get; set; }

  }

}