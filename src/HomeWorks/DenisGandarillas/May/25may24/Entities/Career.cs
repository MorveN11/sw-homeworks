namespace _25may24.Entities
{
    public class Career : IEntityBase
    {

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }

        public ICollection<Candidate> Candidates { get; set; }
        public ICollection<Have> Haves { get; set; }

    }
}
