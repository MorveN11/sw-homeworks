namespace HomeWorks.JeferssonCoronel.May.TwentySecond.Task.LINQMethod.cs
{
    public class Carrier(uint id, string name)
    {
        public uint Id
        {
            get => id;
            set => id = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }
    }

    public class Subject(uint id, string name, string code, byte credit, byte semester)
    {
        public uint Id
        {
            get => id;
            set => id = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Code
        {
            get => code;
            set => code = value;
        }

        public byte Credit
        {
            get => credit;
            set => credit = value;
        }

        public byte Semester
        {
            get => semester;
            set => semester = value;
        }
    }

    public class Study(uint id, uint idStudent, uint idSubject, bool isPassed, byte grade)
    {

        public uint Id
        {
            get => id;
            set => id = value;
        }

        public uint IdStudent
        {
            get => idStudent;
            set => idStudent = value;
        }

        public uint IdSubject
        {
            get => idSubject;
            set => idSubject = value;
        }

        public bool IsPassed
        {
            get => isPassed;
            set => isPassed = value;
        }

        public byte Grade
        {
            get => grade;
            set => grade = value;
        }
    }

    public class Student(uint id, string name, string lastName, uint idCarrier)
    {
        public uint Id
        {
            get => id;
            set => id = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string LastName
        {
            get => lastName;
            set => lastName = value;
        }
        public uint IdCarrier
        {
            get => idCarrier;
            set => idCarrier = value;
        }
    }

    public class DataBase
    {
        private static readonly List<Carrier> Carriers =
        [
            new Carrier(1, "Commercial"),
            new Carrier(2, "Medicine"),
            new Carrier(3, "Engineering"),
        ];

        private static readonly List<Student> Students =
        [
            new Student(1, "Jefersson", "Vargas",1),
            new Student(2, "Carlos", "Pammon",1),
            new Student(3, "Jorge", "Coronel",1),
            new Student(4, "Karina", "Aguirre",1),
            new Student(5, "María", "González", 3),
            new Student(6, "Luis", "Martínez", 3),
            new Student(7, "Ana", "Rodríguez", 3),
            new Student(8, "Pedro", "López", 3),
            new Student(9, "Laura", "Hernández", 3),
            new Student(10, "David", "García", 3),
            new Student(11, "Sofía", "Pérez", 3),
            new Student(12, "Miguel", "Sánchez", 3),
            new Student(13, "Fernanda", "Torres", 3),
            new Student(14, "Alejandro", "Ramírez", 3),
            new Student(15, "Paola", "Díaz", 3)

        ];

        private static readonly List<Study> Studies =
        [
            new Study(1, 1, 2, true, 99),
            new Study(2, 2, 2, false, 30),
            new Study(3, 3, 1, false, 27),
            new Study(4, 4, 3, false, 30),//
            new Study(5, 5, 2, false, 27),
            new Study(6, 6, 2, false, 27),
            new Study(7, 7, 2, false, 27),
            new Study(8, 8, 2, false, 11),
            new Study(9, 9, 2, false, 27),
            new Study(10, 10, 2, false, 27),
            new Study(11, 11, 2, false, 27),
            new Study(12, 12, 2, false, 27),
            new Study(13, 13, 2, false, 10),
            new Study(14, 14, 2, false, 30),
            new Study(15, 15, 2, false, 44), //
            new Study(16, 6, 3, true, 100),
            new Study(17, 7, 2, true, 86),
            new Study(18, 8, 1, true, 88),
            new Study(19, 9, 1, true, 99),
            new Study(20, 10, 1, true, 89),
            new Study(21, 11, 1, true, 97),
            new Study(22, 12, 1, true, 83),
            new Study(23, 13, 1, true, 91),
            new Study(24, 14, 1, true, 99),
        ];

        private readonly List<Subject> _subjects =
        [
            new Subject(1, "Mathematics", "BLK-02", 1, 8),
            new Subject(2, "Biology", "BLK-03", 1, 8),
            new Subject(3, "Programming Languages", "BLK-01", 1,2),
        ];

        public List<(string Name, string LastName, string Subject)> GetStudentsBySubject(string subjectName)
        {
            var studentsBySubject = (
                from student in Students
                join study in Studies on student.Id equals study.IdStudent
                join subject in _subjects on study.IdSubject equals subject.Id
                where subject.Name == subjectName
                select (student.Name, student.LastName, subject.Name)
            ).ToList();

            return studentsBySubject;
        }

        public List<(string Name, string LastName)> GetApprovedStudentsInAllSubjects()
        {
            var approvedStudents = (
                from student in Students
                join study in Studies on student.Id equals study.IdStudent
                where study.IsPassed
                select (student.Name, student.LastName)
            ).Distinct().ToList();

            return approvedStudents;
        }

        // Exercise 1
        public List<(string Name, string LastName, string Subject)> GetStudentsByCarrierAndSemester(string carrierName, byte semester)
        {
            var studentsByCarrierAndSemester = (
                from student in Students
                join study in Studies on student.Id equals study.IdStudent
                join subject in _subjects on study.IdSubject equals subject.Id
                join carrier in Carriers on student.IdCarrier equals carrier.Id
                where carrier.Name == carrierName && subject.Semester == semester
                select (student.Name, student.LastName, subject.Name)
            ).ToList();

            return studentsByCarrierAndSemester;
        }

        // Exercise 2
        public List<(string CarrierName, int FailedStudents)> GetCarriersWithMoreThan10FailedStudents()
        {
            var carriersWithMoreThan10FailedStudents = (
                from student in Students
                join study in Studies on student.Id equals study.IdStudent
                join subject in _subjects on study.IdSubject equals subject.Id
                join carrier in Carriers on student.IdCarrier equals carrier.Id
                where !study.IsPassed
                group study by carrier.Name into carrierGroup
                where carrierGroup.Count() > 10
                select (carrierGroup.Key, carrierGroup.Count())
            ).ToList();

            return carriersWithMoreThan10FailedStudents;
        }

        // Exercise 3
        public List<(string Name, string LastName)> GetTop10StudentsAllCarriers()
        {
            var top10Students = (
                from student in Students
                join study in Studies on student.Id equals study.IdStudent
                join subject in _subjects on study.IdSubject equals subject.Id
                group new { student, study, subject } by new { student.Name, student.LastName, student.IdCarrier } into studentGroup
                let totalCredits = studentGroup.Sum(x => x.subject.Credit)
                let totalGradePoints = studentGroup.Sum(x => x.study.IsPassed ? x.study.Grade * x.subject.Credit : 0)
                let averageGrade = totalGradePoints * 1.0 / totalCredits
                orderby averageGrade descending
                select new { studentGroup.Key.Name, studentGroup.Key.LastName }
            ).Distinct().Take(10).Select(x => (x.Name, x.LastName)).ToList();

            return top10Students;
        }

        // Exercise 4
        public List<(string Subject, int ApprovedStudents)> GetApprovedStudentsBySubject()
        {
            var approvedStudentsBySubject = (
                from study in Studies
                join subject in _subjects on study.IdSubject equals subject.Id
                where study.IsPassed
                group study by subject.Name into subjectGroup
                select (subjectGroup.Key, subjectGroup.Count())
            ).ToList();

            return approvedStudentsBySubject;
        }
    }

    public static class Program
    {
        public static void Main()
        {
            var dataBase = new DataBase();

            Console.WriteLine("Students studying Biology:");
            var studentsBySubject = dataBase.GetStudentsBySubject("Biology");
            foreach (var student in studentsBySubject)
            {
                Console.WriteLine($"- {student.Name} {student.LastName} - {student.Subject}");
            }

            Console.WriteLine("\nApproved Students in All Subjects:");
            var approvedStudents = dataBase.GetApprovedStudentsInAllSubjects();
            foreach (var student in approvedStudents)
            {
                Console.WriteLine($"- {student.Name} {student.LastName}");
            }

            Console.WriteLine("\nStudents in Commercial Carrier and 8th Semester:");
            var studentsByCarrierAndSemester = dataBase.GetStudentsByCarrierAndSemester("Commercial", 8);
            foreach (var student in studentsByCarrierAndSemester)
            {
                Console.WriteLine($"- {student.Name} {student.LastName} - {student.Subject}");
            }

            Console.WriteLine("\nCarriers with more than 10 failed students:");
            var carriersWithMoreThan10FailedStudents = dataBase.GetCarriersWithMoreThan10FailedStudents();
            foreach (var carrier in carriersWithMoreThan10FailedStudents)
            {
                Console.WriteLine($"- {carrier.CarrierName}: {carrier.FailedStudents} failed students");
            }

            Console.WriteLine("\nTop 10 students (all carriers):");
            var top10StudentsByAverageGradeAllCarriers = dataBase.GetTop10StudentsAllCarriers();
            foreach (var student in top10StudentsByAverageGradeAllCarriers)
            {
                Console.WriteLine($"- {student.Name} {student.LastName}");
            }

            Console.WriteLine("\nApproved students by subject:");
            var approvedStudentsBySubject = dataBase.GetApprovedStudentsBySubject();
            foreach (var subject in approvedStudentsBySubject)
            {
                Console.WriteLine($"- {subject.Subject}: {subject.ApprovedStudents} approved students");
            }
        }
    }
}
