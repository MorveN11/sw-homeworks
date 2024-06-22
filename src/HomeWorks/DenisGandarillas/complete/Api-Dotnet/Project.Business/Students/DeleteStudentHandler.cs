using MediatR;

namespace Project.Business.Students
{
    public class DeleteStudentHandler : IRequestHandler<DeleteStudentRequest, int>
    {
        private readonly IStudentRepository _repository;

        public DeleteStudentHandler(IStudentRepository repository)
        {
            _repository = repository;
        }

        public async Task<int> Handle(DeleteStudentRequest request, CancellationToken cancellationToken)
        {
            var student = await _repository.GetById(request.StudentId);
            return await _repository.Delete(student);
        }
    }
}
