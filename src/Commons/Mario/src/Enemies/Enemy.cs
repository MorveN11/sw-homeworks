using Mario.Behaviors;

namespace Mario.Enemies
{
    public abstract class Enemy : IAttack
    {
        public Enemy() { }

        public abstract void Attack();
    }
}
