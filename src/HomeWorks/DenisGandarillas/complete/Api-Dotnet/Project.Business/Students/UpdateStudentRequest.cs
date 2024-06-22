using MediatR;

namespace Project.Business.Students
{
    public class UpdateStudentRequest : IRequest<int>
    {
        public Student Student { get; set; }

        public UpdateStudentRequest(Student student)
        {
            Student = student;
        }
    }
}
