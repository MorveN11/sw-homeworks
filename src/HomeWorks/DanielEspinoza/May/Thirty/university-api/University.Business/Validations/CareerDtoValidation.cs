using FluentValidation;
using University.Business.Dtos;

namespace University.Business.Validators;

    public class CareerDtoValidator : AbstractValidator<CareerDto>
    {
        public CareerDtoValidator()
        {
            RuleFor(dto => dto.Id).NotEmpty().WithMessage("Career Id is required.");
            RuleFor(dto => dto.Name).NotEmpty().WithMessage("Career Name is required.");
            RuleFor(dto => dto.Code)
                .NotEmpty().WithMessage("Career Code is required.")
                .Matches("^[A-Z]{3}[0-9]{3}$").WithMessage("Career Code must be in the format 'XXX000'.");
        }
    }
