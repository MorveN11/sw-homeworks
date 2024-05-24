using University;

namespace IOUTils
{
    public interface IEntityFactory
    {
        T CreateEntity<T>(string[] data) where T : IEntity;
    }



    public class EntityFactory : IEntityFactory
    {
        public T CreateEntity<T>(string[] data) where T : IEntity
        {
            return typeof(T).Name switch
            {
                nameof(Student) => (T)(IEntity)new Student(data),
                nameof(Subject) => (T)(IEntity)new Subject(data),
                nameof(Career) => (T)(IEntity)new Career(data),
                nameof(Candidate) => (T)(IEntity)new Candidate(data),
                nameof(Enrollment) => (T)(IEntity)new Enrollment(data),
                nameof(Study) => (T)(IEntity)new Study(data),
                nameof(Semester) => (T)(IEntity)new Semester(data),
                _ => throw new ArgumentException($"Type {typeof(T).Name} not supported."),
            };
        }

    }

    public class DataLoader
    {
        private readonly IEntityFactory _entityFactory;
        private const string DIRECTORY = "data/";

        private Dictionary<string, string> _fileMap = new()
        {
            { nameof(Student),"students.csv"},
            { nameof(Subject),"subjects.csv"},
            {nameof(Career), "careers.csv"},
            {nameof(Candidate),"candidates.csv" },
            {nameof(Enrollment),"enrollment.csv"},
            {nameof(Study),"study.csv"},
            {  nameof(Semester),"semesters.csv"},
        };

        public DataLoader()
        {
            _entityFactory = new EntityFactory();
        }

        public List<T> LoadEntities<T>() where T : IEntity
        {
            string fileName = _fileMap.FirstOrDefault(kv => kv.Key == typeof(T).Name).Value;
            if (fileName == null)
            {
                Console.WriteLine($"Error: No file found for type {typeof(T).Name}");
                return new List<T>();
            }

            try
            {
                var lines = FileReader.ReadFile(DIRECTORY + fileName);
                return lines.Select(line => _entityFactory.CreateEntity<T>(line.Split(','))).ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading {typeof(T).Name}s: {ex.Message}");
                return new List<T>();
            }
        }

    }
}
