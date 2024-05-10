namespace ChainOfResponsibility
{
    public interface IInquiryHandler
    {
        IInquiryHandler SetNext(IInquiryHandler handler);
        void HandleInquiry(Inquiry inquiry);
    }

    public abstract class AbstractInquiryHandler : IInquiryHandler
    {
        private IInquiryHandler? _nextHandler;

        public IInquiryHandler SetNext(IInquiryHandler handler)
        {
            _nextHandler = handler;
            return handler;
        }

        public virtual void HandleInquiry(Inquiry inquiry)
        {
            if (_nextHandler != null)
            {
                _nextHandler.HandleInquiry(inquiry);
            }
            else
            {
                Console.WriteLine("The inquiry couldn't be resolved.");
            }
        }
    }

    public class BasicInquiryHandler : AbstractInquiryHandler
    {
        public override void HandleInquiry(Inquiry inquiry)
        {
            if (inquiry.Type == InquiryType.General)
            {
                Console.WriteLine($"Basic handler resolved general inquiry: {inquiry.Message}");
            }
            else
            {
                base.HandleInquiry(inquiry);
            }
        }
    }


    public class TeamLeaderHandler : AbstractInquiryHandler
    {
        public override void HandleInquiry(Inquiry inquiry)
        {
            if (inquiry.Type == InquiryType.Escalated)
            {
                Console.WriteLine($"Team leader resolved escalated inquiry: {inquiry.Message}");
            }
            else
            {
                base.HandleInquiry(inquiry);
            }
        }
    }


    public class SupportManagerHandler : AbstractInquiryHandler
    {
        public override void HandleInquiry(Inquiry inquiry)
        {
            if (inquiry.Type == InquiryType.Complex)
            {
                Console.WriteLine($"Support manager resolved complex inquiry: {inquiry.Message}");
            }
            else
            {
                base.HandleInquiry(inquiry);
            }
        }
    }


    public class Inquiry(string message, InquiryType type)
    {
        public string Message { get; set; } = message;
        public InquiryType Type { get; set; } = type;
    }


    public enum InquiryType
    {
        General,
        Escalated,
        Complex
    }

    class Program
    {
        static void Main(string[] args)
        {
            var basicHandler = new BasicInquiryHandler();
            var teamLeaderHandler = new TeamLeaderHandler();
            var supportManagerHandler = new SupportManagerHandler();

            basicHandler.SetNext(teamLeaderHandler).SetNext(supportManagerHandler);

            var inquiry1 = new Inquiry("How do I reset my password?", InquiryType.General);
            var inquiry2 = new Inquiry("I need help with a billing issue.", InquiryType.Escalated);
            var inquiry3 = new Inquiry("There's a critical system error.", InquiryType.Complex);

            basicHandler.HandleInquiry(inquiry1);
            basicHandler.HandleInquiry(inquiry2);
            basicHandler.HandleInquiry(inquiry3);
        }
    }
}
