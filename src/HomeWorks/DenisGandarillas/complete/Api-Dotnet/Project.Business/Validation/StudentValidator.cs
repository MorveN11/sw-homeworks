using FluentValidation;
using Project.Business.DTOs.Student;

namespace Project.Business.Validation
{
  public class StudentValidation : AbstractValidator<StudentDTO>
  {
    public StudentValidation()
    {
      RuleFor(student => student.Name).NotNull().NotEmpty().MaximumLength(50).Matches(@"^[a-zA-Z\s]+$");
      RuleFor(student => student.LastName).NotNull().NotEmpty().MaximumLength(50).Matches(@"^[a-zA-Z\s]+$");
      RuleFor(student => student.Id).NotNull().NotEmpty();
    }
  }
}
