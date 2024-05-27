namespace _25may24.Entities
{

  public class Study
  {

    public Guid Id { get; set; }
    public Guid IdStudent { get; set; }
    public Guid IdSubject { get; set; }
    public int Grade { get; set; }
    public int Semester { get; set; }

    public Student Student { get; set; }
    public Subject Subject { get; set; }

  }

}