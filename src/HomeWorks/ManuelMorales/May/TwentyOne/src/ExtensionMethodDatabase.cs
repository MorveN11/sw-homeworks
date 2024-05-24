namespace TwentyOne
{
    public class ExtensionMethodDatabase : Database
    {
        public ExtensionMethodDatabase(Data data)
            : base(data) { }

        public override IEnumerable<Carrer> GetAllCarrersWithMoreThanTenFailedStudents()
        {
            return Studies
                .Join(
                    Subjects,
                    study => study.IdSubject,
                    subject => subject.Id,
                    (study, subject) => new { study, subject }
                )
                .Join(
                    Semesters,
                    studySubject => studySubject.subject.IdSemester,
                    semester => semester.Id,
                    (studySubject, semester) => new { studySubject.study, semester }
                )
                .Join(
                    Carrers,
                    studySemester => studySemester.semester.IdCarrer,
                    carrer => carrer.Id,
                    (studySemester, carrer) => new { studySemester.study, carrer }
                )
                .Where(studyCarrer => studyCarrer.study.Grade < 51)
                .GroupBy(studyCarrer => studyCarrer.carrer)
                .Where(group => group.Count() > 10)
                .Select(group => group.Key);
        }

        public override IEnumerable<Student> GetAllStudentsTookSubjectEigthSemester()
        {
            return Students
                .Join(
                    Studies,
                    student => student.Id,
                    study => study.IdStudent,
                    (student, study) => new { student, study }
                )
                .Join(
                    Subjects,
                    studentStudy => studentStudy.study.IdSubject,
                    subject => subject.Id,
                    (studentStudy, subject) => new { studentStudy.student, subject }
                )
                .Join(
                    Semesters,
                    studentSubject => studentSubject.subject.IdSemester,
                    semester => semester.Id,
                    (studentSubject, semester) => new { studentSubject.student, semester }
                )
                .Where(studentSemester => studentSemester.semester.Number == 8)
                .Select(studentSemester => studentSemester.student)
                .Distinct();
        }

        public override IEnumerable<(string, int)> GetQuantityOfApprovedStudentsPerSubject()
        {
            return Studies
                .Join(
                    Subjects,
                    study => study.IdSubject,
                    subject => subject.Id,
                    (study, subject) => new { study, subject }
                )
                .GroupBy(studySubject => studySubject.subject.Name)
                .OrderByDescending(group =>
                    group.Count(studySubject => studySubject.study.Grade >= 51)
                )
                .Select(group =>
                    (group.Key, group.Count(studySubject => studySubject.study.Grade >= 51))
                );
        }

        public override IEnumerable<Student> GetTopTenStudents()
        {
            var studentAverageGrades = Students
                .Join(
                    Studies,
                    student => student.Id,
                    study => study.IdStudent,
                    (student, study) => new { student, study }
                )
                .GroupBy(studentStudy => studentStudy.student)
                .Select(group => new
                {
                    Student = group.Key,
                    AverageGrade = group.Average(studentStudy => studentStudy.study.Grade)
                });

            return studentAverageGrades
                .OrderByDescending(studentAverageGrade => studentAverageGrade.AverageGrade)
                .Select(studentAverageGrade => studentAverageGrade.Student)
                .Take(10);
        }
    }
}
