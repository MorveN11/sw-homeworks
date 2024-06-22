using MediatR;

namespace Project.Business.Students;

public class GetStudentById : IRequest<Student>
{
    public Guid StudentId { get; set; }

    public GetStudentById(Guid studentId)
    {
        StudentId = studentId;
    }
    
}