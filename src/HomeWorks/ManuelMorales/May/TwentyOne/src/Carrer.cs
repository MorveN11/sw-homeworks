namespace TwentyOne
{
    public class Carrer
    {
        public ulong Id { get; set; }
        public string Name { get; set; }

        public Carrer(ulong id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}";
        }
    }
}
