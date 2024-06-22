using FluentValidation;
using Project.Business.DTOs.Student;

namespace Project.Business.Validation
{
  
  public class CareerValidation : AbstractValidator<CareerDTO>
  {
    public CareerValidation()
    {
      RuleFor(career => career.Name).NotEmpty().NotNull();
      RuleFor(career => career.Code).NotEmpty().NotNull();
      RuleFor(career => career.Name).Matches(@"^[A-Za-z\s]+$");
      RuleFor(career => career.Code).Matches(@"^[A-Za-z]{1,3}-\d{1,3}$");
      RuleFor(career => career.Name).Length(1, 20);
    
    }
  }

}