namespace _25may24.Entities
{

  public class Have
  {

    public Guid Id { get; set; }
    public Guid IdSubject { get; set; }
    public Guid IdCareer { get; set; }
    public int Semester { get; set; }

    public Subject Subject { get; set; }
    public Career Career { get; set; }

  }

}