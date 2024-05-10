namespace HomeWorks.JeferssonCoronel.May.Nineth.ChainResponsibilityDesignPattern
{
    public enum RequestType
    {
        Billing,
        Technical,
        Product,
        Other
    }

    public class Request(RequestType type)
    {
        public RequestType Type { get; } = type;
    }

    public interface ISupportHandler
    {
        void HandleRequest(Request request);
        void SetNextHandler(ISupportHandler handler);
    }

    public abstract class BaseSupportHandler : ISupportHandler
    {
        private ISupportHandler _nextHandler;

        public void SetNextHandler(ISupportHandler handler)
        {
            _nextHandler = handler;
        }

        public void HandleRequest(Request request)
        {
            if (CanHandle(request))
            {
                ProcessRequest();
            }
            else if (_nextHandler != null)
            {
                _nextHandler.HandleRequest(request);
            }
            else
            {
                Console.WriteLine("-x No handler available to process the request.");
            }
        }

        protected abstract void ProcessRequest();

        protected abstract bool CanHandle(Request request);
    }

    public class BillingHandler : BaseSupportHandler
    {
        protected override void ProcessRequest()
        {
            Console.WriteLine("-> Billing request handled.");
        }

        protected override bool CanHandle(Request request)
        {
            return request.Type == RequestType.Billing;
        }
    }

    public class TechnicalHandler : BaseSupportHandler
    {
        protected override void ProcessRequest()
        {
            Console.WriteLine("-> Technical request handled.");
        }

        protected override bool CanHandle(Request request)
        {
            return request.Type == RequestType.Technical;
        }
    }

    public class ProductHandler : BaseSupportHandler
    {
        protected override void ProcessRequest()
        {
            Console.WriteLine("-> Product request handled.");
        }

        protected override bool CanHandle(Request request)
        {
            return request.Type == RequestType.Product;
        }
    }

    public class CustomerSupportSystem(ISupportHandler firstHandler)
    {
        public void ProcessRequest(Request request)
        {
            firstHandler.HandleRequest(request);
        }
    }

    public static class Program
    {
        public static void Main(string[] args)
        {
            ISupportHandler billingHandler = new BillingHandler();
            ISupportHandler technicalHandler = new TechnicalHandler();
            ISupportHandler productHandler = new ProductHandler();

            billingHandler.SetNextHandler(technicalHandler);
            technicalHandler.SetNextHandler(productHandler);

            CustomerSupportSystem supportSystem = new CustomerSupportSystem(billingHandler);

            supportSystem.ProcessRequest(new Request(RequestType.Billing));
            supportSystem.ProcessRequest(new Request(RequestType.Technical));
            supportSystem.ProcessRequest(new Request(RequestType.Product));
            supportSystem.ProcessRequest(new Request(RequestType.Other));
        }
    }
}
