using MediatR;
using WebApp.Entity;

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
