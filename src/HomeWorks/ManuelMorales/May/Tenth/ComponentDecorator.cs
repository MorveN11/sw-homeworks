namespace Decorator
{
    public class ComponentDecorator : Decorator
    {
        public ComponentDecorator(Component component)
            : base(component) { }

        public override string Operation()
        {
            return $"ComponentDecorator({base.Operation()})";
        }
    }
}
