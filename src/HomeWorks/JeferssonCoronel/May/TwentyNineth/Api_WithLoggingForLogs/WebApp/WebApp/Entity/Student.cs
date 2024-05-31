namespace WebApp.Entity
{
    public class Student : IEntityBase
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }
        public ICollection<StudentCareer> StudentCareers { get; set; }
    }
}
