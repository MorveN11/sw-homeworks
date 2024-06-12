using MediatR;
using WebApp.Entity;

namespace WebApp.Business.Careers
{
    public class CreateCareerRequest : IRequest<int>
    {
        public Career Career { get; set; }

        public CreateCareerRequest(Career career)
        {
            Career = career;
        }
    }
}