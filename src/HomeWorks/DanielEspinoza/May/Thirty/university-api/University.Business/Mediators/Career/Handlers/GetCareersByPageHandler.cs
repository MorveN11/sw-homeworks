using AutoMapper;
using MediatR;
using University.Business.Wrappers;
using University.Domain;

namespace University.Business.Mediators
{
    public class GetCareerByPageHandler : IRequestHandler<GetByPage<Career>, Pagination<Career>>
    {
        private readonly ICareerRepository _careerRepository;

        public GetCareerByPageHandler(ICareerRepository careerRepository, IMapper mapper)
        {
            _careerRepository = careerRepository;

        }


        public async Task<Pagination<Career>> Handle(GetByPage<Career> request, CancellationToken cancellationToken)
        {
            IList<Career> carrers = await _careerRepository.GetByPage(s => true, request.PageNumber, request.PageSize);

            return new Pagination<Career>(request.PageNumber, request.PageSize, carrers);
        }
    }
}
