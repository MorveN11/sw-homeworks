using MediatR;
using WebApp.Entity;

namespace Project.Business.Students;

public class GetStudentCareerHandler : IRequestHandler<GetStudentCareerRequest, IList<Career>>
{
    private readonly IStudentRepository _repository;

    public GetStudentCareerHandler(IStudentRepository repository)
    {
        _repository = repository;
    }
    
    public async Task<IList<Career>> Handle(GetStudentCareerRequest request, CancellationToken cancellationToken)
    {
        var careers = await _repository.GetCareers(request.IdStudent);
        return careers;
    }
}