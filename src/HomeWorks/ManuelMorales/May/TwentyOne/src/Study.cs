namespace TwentyOne
{
    public class Study
    {
        public ulong Id { get; set; }
        public ulong IdStudent { get; set; }
        public ulong IdSubject { get; set; }
        public ushort Grade { get; set; }

        public Study(ulong id, ulong idStudent, ulong idSubject, ushort grade)
        {
            Id = id;
            IdStudent = idStudent;
            IdSubject = idSubject;
            Grade = grade;
        }

        public override string ToString()
        {
            return $"Id: {Id}, IdStudent: {IdStudent}, IdSubject: {IdSubject}, Grade: {Grade}";
        }
    }
}
