using Mario.Enemies;
using Mario.Factories;
using Mario.Handlers;

namespace Mario
{
    public class App
    {
        static void Main(string[] args)
        {
            IEnemyFactory<Tower> towerFactory = new TowerFactory();
            Tower tower = towerFactory.Create();
            DamageHandler<Tower> towerDamageHandler = towerFactory.CreateDamageHandler();
            towerDamageHandler.Handle(tower);

            IEnemyFactory<Shooter> shooterFactory = new ShooterFactory();
            Shooter shooter = shooterFactory.Create();
            DamageHandler<Shooter> shooterDamageHandler = shooterFactory.CreateDamageHandler();
            shooterDamageHandler.Handle(shooter);
        }
    }
}
