namespace _mediator
{

    public interface IMediator
    {

        void Send(string message, Colleague colleague);
        void Register(Colleague colleague);

    }

}
