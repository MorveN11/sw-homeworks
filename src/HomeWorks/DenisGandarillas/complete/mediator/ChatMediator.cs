namespace _mediator
{

    public class ChatMediator : IMediator
    {

        private List<Colleague> colleagues;

        public ChatMediator()
        {
            colleagues = new List<Colleague>();
        }

        public void Register(Colleague colleague)
        {
            colleagues.Add(colleague);
        }

        public void Send(string message, Colleague colleague)
        {
            foreach (Colleague c in colleagues)
            {
                if (c!= colleague)
                {
                    c.Receive(message);
                }
            }
        }

    }

}
