namespace _25may24.Entities
{
    public class Student : IEntityBase
    {

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public DateTime Birthday { get; set; }

        public ICollection<Study> Studies { get; set; }
        public ICollection<Candidate> Candidates { get; set; }

    }
}
