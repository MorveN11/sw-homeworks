using MediatR;

namespace Project.Business.Students;

public class GetStudentCareerHandler : IRequestHandler<GetStudentCareer,IList<Career>>
{
    private readonly IStudentRepository _repository;

    public GetStudentCareerHandler(IStudentRepository repository)
    {
        _repository = repository;
    }
    
    public async Task<IList<Career>> Handle(GetStudentCareer request, CancellationToken cancellationToken)
    {
        var careers = await _repository.GetCareers(request.IdStudent);
        return careers;
    }
}