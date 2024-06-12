using MediatR;
using Project.Business.Students;
using WebApp.Repositories.Interfaces;

namespace WebApp.Business.Careers
{
    public class CreateCareerHandler : IRequestHandler<CreateCareerRequest, int>
    {
        private readonly ICareerRepository _repository;

        public CreateCareerHandler(ICareerRepository repository)
        {
            _repository = repository;
        }

        public async Task<int> Handle(CreateCareerRequest request, CancellationToken cancellationToken)
        {
            return await _repository.Create(request.Career);
        }
    }
}