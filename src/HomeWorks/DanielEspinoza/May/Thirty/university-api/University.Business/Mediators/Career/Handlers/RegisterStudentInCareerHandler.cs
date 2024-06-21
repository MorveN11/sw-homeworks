using MediatR;
using University.Domain;

namespace University.Business.Mediators;


public class RegisterStudentInCareerHandler : IRequestHandler<RegisterStudentInCareer, bool>
{
    private readonly IUnitOfWork _unitOfWork;

    public RegisterStudentInCareerHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }


    public async Task<bool> Handle(RegisterStudentInCareer request, CancellationToken cancellationToken)
    {
        Task<Career?> careerTask = _unitOfWork.Careers.GetById(request.CareerId);
        Task<Student?> studentTask = _unitOfWork.Students.GetById(request.StudentId);

        Career? career =  careerTask.Result;
        Student? student = studentTask.Result;

        if (student is null)
        {
            return false;
        }
        
        career?.Students.Add(student);


        int updated = await _unitOfWork.SaveChangesAsync();

        
        return updated > 0;
    }
}