using MediatR;
using University.Business.Dtos;
using University.Domain;

namespace University.Business.Students
{
    public class UpdateStudent : IRequest<bool>
    {
        public Student Student { get; set; }
        public UpdateStudent(Student student)
        {
            Student = student;
        }
    }
}
