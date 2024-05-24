namespace University
{
    public class Study : IEntity
    {
        public string? StudentId { get; set; }
        public string? SubjectId { get; set; }
        public double? Grade { get; set; }

        public string[] Data { get; }

        public Study(string[] data)
        {
            Data = data;
            StudentId = data[0];
            SubjectId = data[1];
            Grade = double.Parse(data[2]);
        }
    }

    public class Candidate:IEntity
    {
        public string? StudentId { get; set; }
        public string? CareerId { get; set; }

        public string[] Data {get;}

        public Candidate(string[] data)
        {
            Data = data;
            StudentId = data[0];
            CareerId = data[1];
        }
    }

    public class Enrollment:IEntity
    {
        public string? CareerId { get; set; }
        public string? SemesterId { get; set; }
        public string? SubjectId { get; set; }

        public string[] Data {get;}

        public Enrollment(string[] data)
        {
            Data = data;
            CareerId = data[0];
            SemesterId = data[1];
            SubjectId = data[2];
            
        }
    }
}
