using Mario.Enemies;

namespace Mario.Handlers
{
    public class TowerDamageHandler : DamageHandler<Tower>
    {
        public TowerDamageHandler() { }

        public override void Handle(Tower enemy)
        {
            enemy.Attack();
        }
    }
}
