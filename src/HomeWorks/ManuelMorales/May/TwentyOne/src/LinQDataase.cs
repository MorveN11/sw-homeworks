namespace TwentyOne
{
    public class LinQDatabase : Database
    {
        public LinQDatabase(Data data)
            : base(data) { }

        public override IEnumerable<Carrer> GetAllCarrersWithMoreThanTenFailedStudents()
        {
            return (
                from student in Students
                join study in Studies on student.Id equals study.IdStudent
                join subject in Subjects on study.IdSubject equals subject.Id
                join semester in Semesters on subject.IdSemester equals semester.Id
                join carrer in Carrers on semester.IdCarrer equals carrer.Id
                where study.Grade < 51
                group student by carrer into carrerGroup
                where carrerGroup.Count() > 10
                select carrerGroup.Key
            ).Distinct();
        }

        public override IEnumerable<Student> GetAllStudentsTookSubjectEigthSemester()
        {
            return (
                from student in Students
                join study in Studies on student.Id equals study.IdStudent
                join subject in Subjects on study.IdSubject equals subject.Id
                join semester in Semesters on subject.IdSemester equals semester.Id
                where semester.Number == 8
                select student
            ).Distinct();
        }

        public override IEnumerable<(string, int)> GetQuantityOfApprovedStudentsPerSubject()
        {
            return (
                from study in Studies
                join subject in Subjects on study.IdSubject equals subject.Id
                group study by subject.Name into subjectGroup
                orderby subjectGroup.Count(s => s.Grade >= 51) descending
                select (subjectGroup.Key, subjectGroup.Count(s => s.Grade >= 51))
            );
        }

        public override IEnumerable<Student> GetTopTenStudents()
        {
            var studentAverageGrades = (
                from student in Students
                join study in Studies on student.Id equals study.IdStudent
                group study by student into studentGroup
                select new
                {
                    Student = studentGroup.Key,
                    AverageGrade = studentGroup.Average(s => s.Grade)
                }
            );

            return studentAverageGrades
                .OrderByDescending(s => s.AverageGrade)
                .Select(s => s.Student)
                .Take(10);
        }
    }
}
