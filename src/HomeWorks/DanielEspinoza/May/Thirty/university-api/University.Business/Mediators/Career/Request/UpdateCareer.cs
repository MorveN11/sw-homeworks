using MediatR;
using University.Business.Dtos;
using University.Domain;

namespace University.Business.Students
{
    public class UpdateCareer : IRequest<bool>
    {
        public Career Career { get; set; }
        public UpdateCareer(Career career)
        {
            Career = career;
        }
    }
}
