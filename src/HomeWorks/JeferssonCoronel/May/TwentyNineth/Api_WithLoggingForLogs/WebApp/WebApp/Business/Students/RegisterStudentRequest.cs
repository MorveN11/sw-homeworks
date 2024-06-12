using MediatR;
using WebApp.Entity;

namespace WebApp.Business.Students
{
    public class RegisterStudentRequest : IRequest<IList<Career>>
    {
        public Student Student { get; set; }
        public string CareerCode { get; set; }

        public RegisterStudentRequest(Student student, string careerCode)
        {
            Student = student;
            CareerCode = careerCode;
        }
    }
}
