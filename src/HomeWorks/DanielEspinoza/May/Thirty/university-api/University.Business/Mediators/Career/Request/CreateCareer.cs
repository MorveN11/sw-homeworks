using MediatR;
using University.Domain;


namespace University.Business.Mediators;

    public class CreateCareer : IRequest<Guid>
    {
        public Career Career { get; set; }

        public CreateCareer(Career careerRequest)
        {
            Career = careerRequest;
        }
    }
