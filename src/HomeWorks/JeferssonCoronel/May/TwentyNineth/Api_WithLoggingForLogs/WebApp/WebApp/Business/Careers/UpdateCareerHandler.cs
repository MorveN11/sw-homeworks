using MediatR;
using Project.Business.Students;
using WebApp.Repositories.Interfaces;

namespace WebApp.Business.Careers
{
    public class UpdateCareerHandler : IRequestHandler<UpdateCareerRequest, int>
    {
        private readonly ICareerRepository _repository;

        public UpdateCareerHandler(ICareerRepository repository)
        {
            _repository = repository;
        }

        public async Task<int> Handle(UpdateCareerRequest request, CancellationToken cancellationToken)
        {
            return await _repository.Update(request.Career);
        }
    }
}