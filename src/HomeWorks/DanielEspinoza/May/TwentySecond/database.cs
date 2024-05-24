using IOUTils;

namespace University{
       public class Database{
 
        public void LoadDatabase (){
            DataLoader dataloader = new();
            Students = dataloader.LoadEntities<Student>();
            Subjects = dataloader.LoadEntities<Subject>();
            Careers = dataloader.LoadEntities<Career>();
            Candidates = dataloader.LoadEntities<Candidate>();
            Enrollments = dataloader.LoadEntities<Enrollment>();
            Studies = dataloader.LoadEntities<Study>();
            Semesters = dataloader.LoadEntities<Semester>();
        }

        public List<Student> Students { get; set; } = [];
        public List<Subject> Subjects { get; set; } =[];
        public List<Career> Careers { get; set; } = [];
        public List<Candidate> Candidates { get; set; } = [];
        public List<Enrollment> Enrollments { get; set; } = [];
        public List<Study> Studies { get; set; } = [];
        public List<Semester> Semesters { get; set; } = [];
    }
}