using MediatR;

namespace University.Business.Mediators;

public class GetById<T> : IRequest<T>
{
    public Guid EntityId { get; set;}

    public GetById(Guid entityId)
    {
        EntityId = entityId;
    }
}