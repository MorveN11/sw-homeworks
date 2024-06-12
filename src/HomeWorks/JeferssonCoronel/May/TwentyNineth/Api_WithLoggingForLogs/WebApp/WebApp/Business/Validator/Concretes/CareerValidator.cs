using FluentValidation;
using WebApp.Business.Validator.Interfaces;
using WebApp.Entity;

namespace WebApp.Business.Validator.Concretes
{
    public class CareerValidator : AbstractValidator<Career>, ICareerValidator
    {
        public CareerValidator()
        {
            RuleFor(career => career.Id)
                .NotEmpty().WithMessage("Id is required.");

            // Rule for Name
            RuleFor(career => career.Name)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Name is required.")
                .Length(1, 30).WithMessage("Name must be less than 50 characters.")
                .Matches(@"^[a-zA-Z0-9]+$").WithMessage("Name must contain only letters and numbers.");

            // Rule for Code
            RuleFor(career => career.Code)
                .NotEmpty().WithMessage("Code is required.")
                .Matches(@"^[A-Z]{3}-\d{3}$").WithMessage("CareerCode must follow the pattern ABC-123.");
        }
    }
}
