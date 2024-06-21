using AutoMapper;
using MediatR;
using University.Domain;

namespace University.Business.Mediators;


public class GetCareerByIdHandler : IRequestHandler<GetById<Career>, Career?>
{
    private readonly ICareerRepository _careerRepository;

    public GetCareerByIdHandler(ICareerRepository careerRepository,IMapper mapper)
    {
        _careerRepository = careerRepository;
    }

    public async Task<Career?> Handle(GetById<Career> request, CancellationToken cancellationToken)
    {
        Task<Career?> task =  _careerRepository.GetById(request.EntityId);
        return await Task.FromResult(task.Result);
    }
}