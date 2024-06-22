using MediatR;

namespace Project.Business.Students;

public class GetStudentCareer : IRequest<IList<Career>>
{
    public Guid IdStudent { get; set; }

    public GetStudentCareer(Guid idStudent)
    {
        IdStudent = idStudent;
    }
}