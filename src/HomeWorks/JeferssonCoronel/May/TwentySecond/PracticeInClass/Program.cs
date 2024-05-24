namespace HomeWorks.JeferssonCoronel.May.TwentySecond.PracticeInClass.Program.cs
{
    public class Subject(uint id, string name, string code, byte credit)
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
    }

    public class Study(uint id, uint idStudent, uint idSubject, bool isPassed)
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
    }

    public class Student(uint id, string name, string lastName)
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
    }

    public class DataBase
    {
        private readonly List<Student> _students =
        [
            new Student(1, "Carlos", "Vargas"),
            new Student(2, "Jefersson", "Pammon"),
            new Student(3, "Jorge", "Coronel")
        ];

        private readonly List<Study> _studies =
        [
            new Study(1, 1, 2, true),
            new Study(2, 2, 2, false),
            new Study(3, 3, 1, false)
        ];

        private readonly List<Subject> _subjects =
        [
            new Subject(1, "Mathematics", "BLK-02", 1),
            new Subject(2, "Biologia", "BLK-03", 1),
            new Subject(3, "Programming Languages", "BLK-01", 1)
        ];

        //Linq
        public void GetStudentByLastName()
        {
            // var response = Students.Where(student => student.LastName1 == "Vargas"); //where devuelve un IQuerable
            // var response = Students.Where(student => student.LastName1 == "Vargas").Select(student => student.LastName1); //Devuelve String

            //////////////////////////////////////////////////////////////////////// LINQK
            var response =
                from student in _students
                join study in _studies on student.Id equals study.IdStudent
                join subject in _subjects on study.IdSubject equals subject.Id
                where subject.Name == "Biologia"
                select new
                {
                    Name1 = student.Name, LastName1 = student.LastName
                };

            foreach (var student in response)
            {
                Console.WriteLine($"{student.Name1} {student.LastName1}");
            }

            Console.WriteLine(" ================================================================");
            ////////////////////////////////////////////////////////////////////////////////////////////////// EXTENSIONES VARIAS CONSULTAS

            var subjectId = _subjects.Where(subject => subject.Name == "Biologia").Select(subject => subject.Id)
                .FirstOrDefault();
            var studentIds = _studies.Where(study => study.IdSubject == subjectId).Select(study => study.IdStudent)
                .ToList();
            var studentsInSubject = _students.Where(student => studentIds.Contains(student.Id)).ToList();

            foreach (var student in studentsInSubject)
            {
                Console.WriteLine($"{student.Name} {student.LastName}");
            }

            ///////////////////////////////////////////////////////////////////////////////////// EXTENSIONES JOIN
            Console.WriteLine("==================================================================");
            var response1 = _students.Join(
                _studies,
                student => student.Id,
                study => study.IdStudent,
                (student, study) => new { Name1 = student.Name, LastName1 = student.LastName, IdSubject1 = study.IdSubject }).Join(
                _subjects,
                ss => ss.IdSubject1,
                subject => subject.Id,
                (ss, subject) => new { ss.Name1, ss.LastName1, Subject = subject.Name }).Where(
                s => s.Subject == "Biologia").Select(s => new { s.Name1, s.LastName1, s.Subject });


            foreach (var student in response1)
            {
                Console.WriteLine($"{student.Name1} {student.LastName1}");
            }

            /// Estudiantes aprobados Expression
            Console.WriteLine("==================================================");
            var approvedStudents = _students.Join(
                    _studies,
                    student => student.Id,
                    study => study.IdStudent,
                    (student, study) => new { Name1 = student.Name, LastName1 = student.LastName, IsPassed1 = study.IsPassed })
                .Where(s => s.IsPassed1)
                .Select(s => new { s.Name1, s.LastName1 })
                .Distinct()
                .ToList();

            foreach (var student in approvedStudents)
            {
                Console.WriteLine($"{student.Name1} {student.LastName1}");
            }

        }
    }

    public class Program
    {
        public static void Main()
        {
            DataBase dataBase = new DataBase();
            dataBase.GetStudentByLastName();
        }
    }
}
