namespace Decorator
{
    public class App
    {
        static void Main(String[] args)
        {
            var component = new ConcreteComponent();

            Console.WriteLine("Client: I get a simple component:");
            Console.WriteLine(component.Operation());

            var decorator = new ComponentDecorator(component);

            Console.WriteLine("Client: Now I've got a decorated component:");
            Console.WriteLine(decorator.Operation());
        }
    }
}
