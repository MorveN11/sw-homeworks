using MediatR;
using University.Business.Students;
using University.Domain;


namespace University.Business.Mediators;

public class UpdateStudentHandler : IRequestHandler<UpdateStudent, bool>
{
    private readonly IStudentRepository _studentRepository;

    public UpdateStudentHandler(IStudentRepository studentRepository)
    {
        _studentRepository = studentRepository;
    }
    
    public async Task<bool> Handle(UpdateStudent request, CancellationToken cancellationToken)
    {
        return 0 !=await _studentRepository.Update(request.Student);
        
    }
}