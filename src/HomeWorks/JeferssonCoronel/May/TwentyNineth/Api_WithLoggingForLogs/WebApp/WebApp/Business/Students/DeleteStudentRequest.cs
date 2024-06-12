using MediatR;

namespace Project.Business.Students
{
    public class DeleteStudentRequest : IRequest<int>
    {
        public Guid StudentId { get; set; }

        public DeleteStudentRequest(Guid studentId)
        {
            StudentId = studentId;
        }
    }
}
