namespace TwentyOne
{
    public class Student
    {
        public ulong Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public ulong IdCarrer { get; set; }

        public Student(ulong id, string name, string lastName, ulong idCarrer)
        {
            Id = id;
            Name = name;
            LastName = lastName;
            IdCarrer = idCarrer;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, LastName: {LastName}, IdCarrer: {IdCarrer}";
        }
    }
}
