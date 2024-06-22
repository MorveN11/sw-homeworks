using MediatR;
using University.Business.Students;
using University.Domain;

namespace University.Business.Mediators;

public class DeleteStudentHandler : IRequestHandler<DeleteStudent, bool>
{
    private readonly IStudentRepository _studentRepository;

    public DeleteStudentHandler(IStudentRepository studentRepository)
    {
        _studentRepository = studentRepository;
    }
    public async Task<bool> Handle(DeleteStudent request, CancellationToken cancellationToken)
    {
        Task<Student?> student =  _studentRepository.GetById(request.StudentId);
        if (student.Result is null)
        {
            return false;
        }
        
        return await _studentRepository.Delete(student.Result);
    }
}