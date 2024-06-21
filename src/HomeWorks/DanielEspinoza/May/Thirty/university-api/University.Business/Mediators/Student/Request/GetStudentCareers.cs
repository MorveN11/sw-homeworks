using MediatR;
using University.Domain;
namespace University.Business.Mediators;

public class GetStudentCareers : IRequest<IList<Career>>
{
    public Guid IdStudent { get; set; }

    public GetStudentCareers(Guid idStudent)
    {
        IdStudent = idStudent;
    }
}