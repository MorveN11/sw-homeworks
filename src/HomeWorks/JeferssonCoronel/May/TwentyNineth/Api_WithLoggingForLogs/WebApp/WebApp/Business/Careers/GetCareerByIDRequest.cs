using MediatR;
using WebApp.Entity;

namespace WebApp.Business.Careers
{
    public class GetCareerByIDRequest : IRequest<Career>
    {
        public Guid CareerId { get; set; }

        public GetCareerByIDRequest(Guid careerId)
        {
            CareerId = careerId;
        }
    }
}
