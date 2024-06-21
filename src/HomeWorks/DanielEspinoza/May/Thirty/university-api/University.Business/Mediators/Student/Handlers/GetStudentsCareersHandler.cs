using MediatR;
using University.Domain;

namespace University.Business.Mediators;


public class GetStudentsCareersHandler : IRequestHandler<GetStudentCareers, IList<Career>>
{
    private readonly IStudentRepository _studentRepository;

    public GetStudentsCareersHandler(IStudentRepository studentRepository)
    {
        _studentRepository = studentRepository;
    }

    public async Task<IList<Career>> Handle(GetStudentCareers request, CancellationToken cancellationToken)
    {
        Task<IList<Career>> task =  _studentRepository.GetCareers(request.IdStudent);
        return  await Task.FromResult(task.Result);
    }
}