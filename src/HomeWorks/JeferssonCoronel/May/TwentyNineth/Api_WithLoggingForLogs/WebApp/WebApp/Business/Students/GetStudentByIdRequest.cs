using MediatR;
using WebApp.Entity;

namespace Project.Business.Students;

public class GetStudentByIdRequest : IRequest<Student>
{
    public Guid StudentId { get; set; }

    public GetStudentByIdRequest(Guid studentId)
    {
        StudentId = studentId;
    }
}