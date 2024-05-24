namespace University
{

    public interface IEntity
    {
        string [] Data { get;}
    }

    public enum Semesters
    {
        FIRST = 1,
        SECOND = 2,
        THIRD = 3,
        FOURTH = 4,
        FIFTH = 5,
        SIXTH = 6,
        SEVENTH = 7,
        EIGHT = 8
    }


    public class Student: IEntity
    {
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public string? Id { get; set; }

        public string[] Data {get;}

        public Student(string[] data)
        {
            Data = data;
            Name = data[0];
            LastName = data[1];
            Id = data[2];
        }
    }

    public class Subject:IEntity
    {
        public string? Name { get; set; }
        public string? Id { get; set; }

        public string[] Data{get;}

        public Subject(string[] data)
        {
            Data = data;
            Name = data[0];
            Id = data[1];
        }
    }

    public class Semester:IEntity
    {
        public Semesters Number { get; set; }
        public string? Id { get; set; }

        public string[] Data {get;}

        public Semester(string[] data)
        {
            Data = data;
            Number = (Semesters)int.Parse(data[0]);
            Id = data[1];
        }
    }

    public class Career:IEntity
    {
        public string? Name { get; set; }
        public string? Id { get; set; }

        public string[] Data {get;}

        public Career(string[] data)
        {
            Data = data;
            Name = data[0];
            Id = data[1];
        }
    }


}