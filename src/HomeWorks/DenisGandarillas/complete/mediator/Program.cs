namespace _mediator
{

    public class Program
    {

        public static void Main(string[] args)
        {
            IMediator mediator = new ChatMediator();

            User denis = new User(mediator, "Denis");
            User lucia = new User(mediator, "Lucia");

            mediator.Register(denis);
            mediator.Register(lucia);

            denis.Send("Buenas buenas :D");
            lucia.Send("Hola :)");
        }

    }

}
