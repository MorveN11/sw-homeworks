namespace Decorator
{
    public abstract class Decorator : Component
    {
        protected readonly Component _component;

        public Decorator(Component component)
        {
            _component = component;
        }

        public virtual string Operation()
        {
            return _component.Operation();
        }
    }
}
