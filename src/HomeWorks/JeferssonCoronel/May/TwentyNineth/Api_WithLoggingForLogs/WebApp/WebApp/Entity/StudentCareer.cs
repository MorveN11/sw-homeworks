namespace WebApp.Entity
{
    public class StudentCareer
    {
        public Guid Id { get; set; }
        public Guid StudentId { get; set; }
        public Student Student { get; set; }
        public Guid CareerId { get; set; }
        public Career Career { get; set; }
    }
}
