using Mario.Enemies;
using Mario.Handlers;

namespace Mario.Factories
{
    public class ShooterFactory : IEnemyFactory<Shooter>
    {
        public ShooterFactory() { }

        public Shooter Create()
        {
            return new Shooter();
        }

        public DamageHandler<Shooter> CreateDamageHandler()
        {
            return new ShooterDamageHandler();
        }
    }
}
