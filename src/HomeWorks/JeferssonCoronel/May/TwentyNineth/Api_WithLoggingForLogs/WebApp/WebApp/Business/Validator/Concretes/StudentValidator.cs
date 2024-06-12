using FluentValidation;
using Project.Business.DTOs.Student;
using WebApp.Business.Validator.Interfaces;
using WebApp.Entity;

namespace WebApp.Business.Validator.Concretes
{
    public class StudentValidator : AbstractValidator<Student>, IStudentValidator
    {
        public StudentValidator()
        {
            RuleFor(student => student.Id)
                .NotEmpty().WithMessage("Id is required.");

            RuleFor(student => student.Name)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Name is required.")
                .Length(1, 50).WithMessage("Name must be less than 50 characters.")
                .Matches(@"^[a-zA-Z0-9]+$").WithMessage("Name must contain only letters and numbers.");

            RuleFor(student => student.LastName)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("LastName is required.")
                .Length(1, 50).WithMessage("LastName must be less than 50 characters.")
                .Matches(@"^[a-zA-Z0-9]+$").WithMessage("LastName must contain only letters and numbers.");

            RuleFor(student => student.BirthDate)
                .NotEmpty().WithMessage("BirthDate is required.");
        }
    }
}
