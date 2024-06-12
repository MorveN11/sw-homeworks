namespace WebApp.Entity
{
    public class Student : IEntityBase
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public List<Career> Careers { get; set; } = [];
    }
}
