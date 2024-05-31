namespace WebApp.Entity
{
    public class Career : IEntityBase
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public ICollection<StudentCareer> StudentCareers { get; set; }
    }
}
