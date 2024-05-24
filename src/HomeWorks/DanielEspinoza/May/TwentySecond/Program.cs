
namespace University{
    public class Program
    {
        static void Main(string[] args)
        {
            Database database = new();
            database.LoadDatabase();

            Console.WriteLine("Comercial career Stundets in eigth semester with just one subject:\n");
            var eigthSemesterStudents = from career in database.Careers
                                        where career.Name == "Comercial"
                                        join enrollment in database.Enrollments on career.Id equals enrollment.CareerId
                                        join semesters in database.Semesters on enrollment.SemesterId equals semesters.Id
                                        where semesters.Number == Semesters.EIGHT
                                        join studies in database.Studies on enrollment.SubjectId equals studies.SubjectId
                                        group studies by studies.StudentId into studentGroup
                                        where studentGroup.Count() == 1
                                        join student in database.Students on studentGroup.Key equals student.Id
                                        select student;


            foreach (var student in eigthSemesterStudents)
            {
                Console.WriteLine($"{student.Name} {student.LastName}");
            }
            Console.WriteLine("\n\n**************************************");
            Console.WriteLine("Careers with more than 10 students:\n");
       

            var careersWithMoreThan10Students = from career in database.Careers
                                    join enrollment in database.Enrollments on career.Id equals enrollment.CareerId
                                    join study in database.Studies on enrollment.SubjectId equals study.SubjectId
                                    join student in database.Students on study.StudentId equals student.Id
                                    group student by career into careerGroup
                                    where careerGroup.Count() > 10
                                    select new
                                    {
                                        CareerName = careerGroup.Key.Name
                                    };

            foreach (var career in careersWithMoreThan10Students)
            {
                Console.WriteLine(career.CareerName);
            }
        
            Console.WriteLine("\n\n**************************************");
            Console.WriteLine("Top 10 best students:\n");

            var bestStudents = (from student in database.Students
                        join studies in database.Studies on student.Id equals studies.StudentId
                        group new { student, studies } by new { student.Id, student.Name, student.LastName } into studentGroup
                        orderby studentGroup.Average(x => x.studies.Grade) descending
                        select new
                        {
                            Name = studentGroup.Key.Name,
                            LastName = studentGroup.Key.LastName,
                            AverageGrade = studentGroup.Average(x => x.studies.Grade)
                        }).Take(10);

            foreach (var student in bestStudents)
            {
                Console.WriteLine($"{student.Name} {student.LastName} - {student.AverageGrade}");
            }


            Console.WriteLine("\n\n**************************************");
            Console.WriteLine("Approved students by subject:\n");
            var approvedStudentsBySubject =  from studies in database.Studies
                                             join subjects in database.Subjects on studies.SubjectId equals subjects.Id
                                             where studies.Grade >= 51
                                             group subjects by new { studies.SubjectId, subjects.Name } into subjectGroup
                                             select new
                                             {
                                                 SubjectName = subjectGroup.Key.Name,
                                                 ApprovedStudentsAmount = subjectGroup.Count()
                                             };


            foreach (var subject in approvedStudentsBySubject)
            {
                Console.WriteLine($"{subject.SubjectName} - {subject.ApprovedStudentsAmount}");
            }
                                             

            
        }

    }



}