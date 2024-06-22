using FluentValidation;
using University.Business.Dtos;

namespace University.Business.Validators;

public class StudentDtoValidator : AbstractValidator<StudentDto>
{
    public StudentDtoValidator()
    {
        RuleFor(dto => dto.Id).NotEmpty().WithMessage("Student Id is required.");
        RuleFor(dto => dto.Name).NotEmpty().WithMessage("Student Name is required.");
        RuleFor(dto => dto.LastName).NotEmpty().WithMessage("Student Last Name is required.");
        RuleFor(dto => dto.BirthDate)
            .NotEmpty().WithMessage("Student Birth Date is required.")
            .Must(BeAValidDate).WithMessage("Student Birth Date must be a valid date in the past.");
    }

    private bool BeAValidDate(DateTime date)
    {
        return date < DateTime.UtcNow;
    }
}
