using MediatR;
using WebApp.Entity;

namespace Project.Business.Students;

public class GetStudentByIdHandler : IRequestHandler<GetStudentByIdRequest, Student>
{
    private readonly IStudentRepository _repository;

    public GetStudentByIdHandler(IStudentRepository repository)
    {
        _repository = repository;
    }
    
    public async Task<Student> Handle(GetStudentByIdRequest request, CancellationToken cancellationToken)
    {
        var student = await _repository.GetById(request.StudentId);
        return student;
    }
}