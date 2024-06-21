namespace _mediator
{

    public class User : Colleague
    {

        public string Name { get; set; }

        public User(IMediator mediator, string name) : base(mediator)
        {
            Name = name;
        }

        public void Send(string message)
        {
            Console.WriteLine(Name + " sends: " + message);
            mediator.Send(message, this);
        }

        public override void Receive(string message)
        {
            Console.WriteLine(Name + " receives: " + message);
        }

    }

}
