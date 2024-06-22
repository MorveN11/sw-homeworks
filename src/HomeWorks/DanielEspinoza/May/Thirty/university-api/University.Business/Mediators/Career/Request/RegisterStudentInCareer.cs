using MediatR;
using University.Business.Dtos;
namespace University.Business.Mediators;

public class RegisterStudentInCareer : IRequest<bool>
{
    public Guid StudentId { get; set; }
    public Guid CareerId { get; set; }

    public RegisterStudentInCareer(Guid careerId, Guid studentId)
    {
        CareerId = careerId;
        StudentId = studentId;
    }
}