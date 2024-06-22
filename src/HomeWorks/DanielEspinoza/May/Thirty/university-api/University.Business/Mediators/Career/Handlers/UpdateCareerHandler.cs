using MediatR;
using University.Business.Students;
using University.Domain;


namespace University.Business.Mediators;

public class UpdateCareerHandler : IRequestHandler<UpdateCareer, bool>
{
    private readonly ICareerRepository _careerRepository;

    public UpdateCareerHandler(ICareerRepository careerRepository)
    {
        _careerRepository = careerRepository;
    }
    
    public async Task<bool> Handle(UpdateCareer request, CancellationToken cancellationToken)
    {
       return 0 > await _careerRepository.Update(request.Career);
       
    }
}