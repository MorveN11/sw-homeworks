namespace TwentyOne
{
    public abstract class Database
    {
        public List<Carrer> Carrers { get; set; }
        public List<Student> Students { get; set; }
        public List<Semester> Semesters { get; set; }
        public List<Subject> Subjects { get; set; }
        public List<Study> Studies { get; set; }

        public Database(Data data)
        {
            Carrers = data.Carrers;
            Students = data.Students;
            Semesters = data.Semesters;
            Subjects = data.Subjects;
            Studies = data.Studies;
        }

        public abstract IEnumerable<Student> GetAllStudentsTookSubjectEigthSemester();

        public abstract IEnumerable<Carrer> GetAllCarrersWithMoreThanTenFailedStudents();

        public abstract IEnumerable<Student> GetTopTenStudents();

        public abstract IEnumerable<(string, int)> GetQuantityOfApprovedStudentsPerSubject();
    }
}
