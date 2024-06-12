using MediatR;
using Project.Business.Students;
using WebApp.Entity;
using WebApp.Repositories.Interfaces;

namespace WebApp.Business.Careers
{
    public class GetCareerByIDHandler : IRequestHandler<GetCareerByIDRequest, Career>
    {
        private readonly ICareerRepository _repository;

        public GetCareerByIDHandler(ICareerRepository repository)
        {
            _repository = repository;
        }

        public async Task<Career> Handle(GetCareerByIDRequest request, CancellationToken cancellationToken)
        {
            var career = await _repository.GetById(request.CareerId);
            return career;
        }
    }
}
