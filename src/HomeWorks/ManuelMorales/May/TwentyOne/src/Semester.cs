namespace TwentyOne
{
    public class Semester
    {
        public ulong Id { get; set; }
        public ulong Number { get; set; }
        public ulong IdCarrer { get; set; }

        public Semester(ulong id, ulong number, ulong idCarrer)
        {
            Id = id;
            Number = number;
            IdCarrer = idCarrer;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Number: {Number}, IdCarrer: {IdCarrer}";
        }
    }
}
