using MediatR;

namespace Project.Business.Students
{
    public class CreateStudentRequest : IRequest<int>
    {
        public Student Student { get; set; }

        public CreateStudentRequest(Student student)
        {
            Student = student;
        }
    }
}
