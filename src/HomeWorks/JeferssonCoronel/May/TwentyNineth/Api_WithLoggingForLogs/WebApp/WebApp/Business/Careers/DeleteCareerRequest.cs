using MediatR;

namespace WebApp.Business.Careers
{
    public class DeleteCareerRequest : IRequest<int>
    {
        public Guid CareerId { get; set; }

        public DeleteCareerRequest(Guid careerId)
        {
            CareerId = careerId;
        }
    }
}
