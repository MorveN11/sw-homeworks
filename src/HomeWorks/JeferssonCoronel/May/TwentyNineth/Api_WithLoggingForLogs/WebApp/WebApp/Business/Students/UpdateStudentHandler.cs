using MediatR;
namespace Project.Business.Students
{
    public class UpdateStudentHandler : IRequestHandler<UpdateStudentRequest, int>
    {
        private readonly IStudentRepository _repository;

        public UpdateStudentHandler(IStudentRepository repository)
        {
            _repository = repository;
        }

        public async Task<int> Handle(UpdateStudentRequest request, CancellationToken cancellationToken)
        {
            return await _repository.Update(request.Student);
        }
    }
}