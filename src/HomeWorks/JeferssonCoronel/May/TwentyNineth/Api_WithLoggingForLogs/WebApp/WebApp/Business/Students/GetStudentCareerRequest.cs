using MediatR;
using WebApp.Entity;

namespace Project.Business.Students;

public class GetStudentCareerRequest : IRequest<IList<Career>>
{
    public Guid IdStudent { get; set; }

    public GetStudentCareerRequest(Guid idStudent)
    {
        IdStudent = idStudent;
    }
}