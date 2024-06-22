using MediatR;
using University.Business.Dtos;
using University.Domain;

namespace University.Business.Mediators;

public record CreateCareerHandler : IRequestHandler<CreateCareer, Guid>
{
    private readonly ICareerRepository _careerRepository;

    public CreateCareerHandler(ICareerRepository careerRepository)
    {
        _careerRepository = careerRepository;
    }
    public async Task<Guid> Handle(CreateCareer request, CancellationToken cancellationToken)
    {
        await _careerRepository.Create(request.Career);
        return request.Career.Id;
    }
}