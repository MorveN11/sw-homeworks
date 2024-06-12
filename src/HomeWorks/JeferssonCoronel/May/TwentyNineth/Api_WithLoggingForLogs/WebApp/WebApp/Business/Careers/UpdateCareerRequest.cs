using MediatR;
using WebApp.Entity;

namespace WebApp.Business.Careers
{
    public class UpdateCareerRequest : IRequest<int>
    {
        public Career Career { get; set; }

        public UpdateCareerRequest(Career career)
        {
            Career = career;
        }
    }
}
