namespace src.HomeWorks.JeferssonCoronel.May.TwentyNineth.MediatorDesignPattern
{
    // Mediator
    interface IChatRoomMediator
    {
        void SendMessage(string message, User user);
    }

    // Concrete Mediator
    class ChatRoomMediatorImpl : IChatRoomMediator
    {
        private List<User> users;

        public ChatRoomMediatorImpl()
        {
            users = new List<User>();
        }

        public void AddUser(User user)
        {
            users.Add(user);
        }

        public void SendMessage(string message, User user)
        {
            foreach (User u in users)
            {
                if (u != user)
                {
                    u.Receive(message);
                }
            }
        }
    }

    // Colleague
    abstract class User
    {
        protected IChatRoomMediator mediator;
        protected string name;

        public User(IChatRoomMediator mediator, string name)
        {
            this.mediator = mediator;
            this.name = name;
        }

        public abstract void Send(string message);

        public abstract void Receive(string message);
    }

    // Concrete Colleagues
    class UserImpl : User
    {
        public UserImpl(IChatRoomMediator mediator, string name) : base(mediator, name)
        {
        }

        public override void Send(string message)
        {
            Console.WriteLine(name + ": Enviando Mensaje: " + message);
            mediator.SendMessage(message, this);
        }

        public override void Receive(string message)
        {
            Console.WriteLine(name + ": Recibido Mensaje: " + message);
        }
    }

    // Ejemplo de uso
    class MediatorExample
    {
        static void Main(string[] args)
        {
            ChatRoomMediatorImpl mediator = new ChatRoomMediatorImpl();

            User user1 = new UserImpl(mediator, "Juan");
            User user2 = new UserImpl(mediator, "María");
            User user3 = new UserImpl(mediator, "Pedro");

            mediator.AddUser(user1);
            mediator.AddUser(user2);
            mediator.AddUser(user3);

            user1.Send("Hola a todos!");
            user3.Send("Saludos!");
        }
    }
}