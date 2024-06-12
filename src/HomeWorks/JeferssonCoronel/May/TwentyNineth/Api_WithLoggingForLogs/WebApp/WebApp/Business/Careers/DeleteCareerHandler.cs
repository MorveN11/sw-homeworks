using MediatR;
using WebApp.Repositories.Interfaces;

namespace WebApp.Business.Careers
{
    public class DeleteCareerHandler : IRequestHandler<DeleteCareerRequest, int>
    {
        private readonly ICareerRepository _repository;

        public DeleteCareerHandler(ICareerRepository repository)
        {
            _repository = repository;
        }

        public async Task<int> Handle(DeleteCareerRequest request, CancellationToken cancellationToken)
        {
            var career = await _repository.GetById(request.CareerId);
            return await _repository.Delete(career);
        }
    }
}
