using MediatR;
using University.Business.Dtos;
using University.Domain;

namespace University.Business.Mediators;

public record CreateStudentHandler : IRequestHandler<CreateStudent, Guid>
{
    private readonly IStudentRepository _studentRepository;

    public CreateStudentHandler(IStudentRepository studentRepository)
    {
        _studentRepository = studentRepository;
    }
    public async Task<Guid> Handle(CreateStudent request, CancellationToken cancellationToken)
    {
        await _studentRepository.Create(request.Student);
        return request.Student.Id;
    }
}