using MediatR;

namespace Project.Business.Students
{
    public class CreateStudentHandler : IRequestHandler<CreateStudentRequest, int>
    {
        private readonly IStudentRepository _repository;

        public CreateStudentHandler(IStudentRepository repository)
        {
            _repository = repository;
        }

        public async Task<int> Handle(CreateStudentRequest request, CancellationToken cancellationToken)
        {
            return await _repository.Create(request.Student);
        }
    }
}
