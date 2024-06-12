using FluentValidation;
using MediatR;
using Project.Business.Students;
using WebApp.Business.Validator.Concretes;
using WebApp.Entity;
using WebApp.Repositories.Interfaces;

namespace WebApp.Business.Students
{
    public class RegisterStudentHandler : IRequestHandler<RegisterStudentRequest, IList<Career>>
    {
        private readonly IStudentRepository _studentRepository;
        private readonly ICareerRepository _careerRepository;

        private readonly StudentValidator _validator;

        public RegisterStudentHandler(IStudentRepository studentRepository, ICareerRepository careerRepository, StudentValidator studentValidator)
        {
            _studentRepository = studentRepository;
            _careerRepository = careerRepository;
            _validator = studentValidator;
        }

        public async Task<IList<Career>> Handle(RegisterStudentRequest request, CancellationToken cancellationToken)
        {
            _validator.ValidateAndThrow(request.Student);

            var careers = await _careerRepository.Read(c => c.Code.Equals(request.CareerCode));

            if (careers.Any())
            {

            }
            else
            {
                // TODO: Handler response error
            }
            throw new NotImplementedException();
        }
    }
}