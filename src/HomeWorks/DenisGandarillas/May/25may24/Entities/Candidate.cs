namespace _25may24.Entities
{

  public class Candidate
  {

    public Guid Id { get; set; }
    public Guid IdStudent { get; set; }
    public Guid IdCareer { get; set; }
    public int Semester { get; set; }

    public Student Student { get; set; }
    public Career Career { get; set; }

  }

}