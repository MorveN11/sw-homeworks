using System;

namespace api_dotnet.Entities
{
    public class Study
    {
        public Guid Id { get; set; }
        public Guid CareerId { get; set; }
        public Career Career { get; set; }
        public Guid StudentId { get; set; }
        public Student Student { get; set; }
        public string Notas { get; set; }
    }
}
