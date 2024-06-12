using MediatR;
using WebApp.Entity;

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
