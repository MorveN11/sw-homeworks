using MediatR;
using University.Business.Students;
using University.Domain;

namespace University.Business.Mediators;

public class DeleteCareerHandler : IRequestHandler<DeleteCareer, bool>
{
    private readonly ICareerRepository _careerRepository;

    public DeleteCareerHandler(ICareerRepository careerRepository)
    {
        _careerRepository = careerRepository;
    }
    public async Task<bool> Handle(DeleteCareer request, CancellationToken cancellationToken)
    {
        Task<Career?> career =  _careerRepository.GetById(request.CareerId);
        
        if (career.Result is null)
            return false;
        
        return await _careerRepository.Delete(career.Result);
    }
}