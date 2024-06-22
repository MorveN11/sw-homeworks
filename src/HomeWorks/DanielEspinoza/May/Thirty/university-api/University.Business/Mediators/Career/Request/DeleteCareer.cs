using MediatR;

namespace University.Business.Students
{
    public class DeleteCareer : IRequest<bool>
    {
        public Guid CareerId { get; set; }

        public DeleteCareer(Guid careerIdId)
        {
            CareerId = careerIdId;
        }
    }
}
