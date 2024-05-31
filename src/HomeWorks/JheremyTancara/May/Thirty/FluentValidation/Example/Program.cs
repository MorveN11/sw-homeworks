using System;
using FluentValidation;
using FluentValidation.Results;

public class Customer
{
    public string Name { get; set; }
    public string Email { get; set; }
    public int Age { get; set; }
}

public class CustomerValidator : AbstractValidator<Customer>
{
    public CustomerValidator()
    {
        RuleFor(customer => customer.Name).NotEmpty().WithMessage("Name is required.");
        RuleFor(customer => customer.Email).EmailAddress().WithMessage("A valid email is required.");
        RuleFor(customer => customer.Age).InclusiveBetween(18, 60).WithMessage("Age must be between 18 and 60.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        var customer = new Customer { Name = "", Email = "invalidemail", Age = 70 };

        var validator = new CustomerValidator();
        ValidationResult results = validator.Validate(customer);

        if (!results.IsValid)
        {
            foreach (var failure in results.Errors)
            {
                Console.WriteLine($"Property {failure.PropertyName} failed validation. Error: {failure.ErrorMessage}");
            }
        }
        else
        {
            Console.WriteLine("Customer details are valid.");
        }
    }
}
