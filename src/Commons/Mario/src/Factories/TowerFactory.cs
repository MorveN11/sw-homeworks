using Mario.Enemies;
using Mario.Handlers;

namespace Mario.Factories
{
    public class TowerFactory : IEnemyFactory<Tower>
    {
        public TowerFactory() { }

        public Tower Create()
        {
            return new Tower();
        }

        public DamageHandler<Tower> CreateDamageHandler()
        {
            return new TowerDamageHandler();
        }
    }
}
