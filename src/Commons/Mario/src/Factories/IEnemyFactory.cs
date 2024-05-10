using Mario.Enemies;
using Mario.Handlers;

namespace Mario.Factories
{
    public interface IEnemyFactory<T>
        where T : Enemy, new()
    {
        T Create();
        DamageHandler<T> CreateDamageHandler();
    }
}
