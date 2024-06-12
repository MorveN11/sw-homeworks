using MediatR;
using WebApp.Entity;

namespace WebApp.Business.Careers
{
    public class GetCareersStudentsRequest : IRequest<IList<Student>>
    {
        public Guid IdCareer { get; set; }

        public GetCareersStudentsRequest(Guid idCareer)
        {
            IdCareer = idCareer;
        }
    }
}