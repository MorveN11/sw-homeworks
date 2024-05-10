using Mario.Enemies;

namespace Mario.Handlers
{
    public abstract class DamageHandler<T>
        where T : Enemy, new()
    {
        public DamageHandler() { }

        public abstract void Handle(T enemy);
    }
}
