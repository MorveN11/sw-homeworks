namespace TwentyOne
{
    public class Subject
    {
        public ulong Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public ushort Credit { get; set; }
        public ulong IdSemester { get; set; }

        public Subject(ulong id, string name, string code, ushort credit, ulong idSemester)
        {
            Id = id;
            Name = name;
            Code = code;
            Credit = credit;
            IdSemester = idSemester;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Code: {Code}, Credit: {Credit}, IdSemester: {IdSemester}";
        }
    }
}
