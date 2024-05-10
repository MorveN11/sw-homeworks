using Mario.Enemies;

namespace Mario.Handlers
{
    public class ShooterDamageHandler : DamageHandler<Shooter>
    {
        public ShooterDamageHandler() { }

        public override void Handle(Shooter enemy)
        {
            enemy.Attack();
            enemy.Move();
        }
    }
}
