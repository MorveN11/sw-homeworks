using MediatR;
using University.Domain;


namespace University.Business.Mediators;

    public class CreateStudent : IRequest<Guid>
    {
        public Student Student { get; set; }

        public CreateStudent(Student student)
        {
            Student = student;
        }
    }
