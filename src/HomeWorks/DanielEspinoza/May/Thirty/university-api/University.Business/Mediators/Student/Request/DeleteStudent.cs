using MediatR;

namespace University.Business.Students
{
    public class DeleteStudent : IRequest<bool>
    {
        public Guid StudentId { get; set; }

        public DeleteStudent(Guid studentId)
        {
            StudentId = studentId;
        }
    }
}
