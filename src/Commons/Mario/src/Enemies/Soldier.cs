using Mario.Behaviors;

namespace Mario.Enemies
{
    public abstract class Soldier : Enemy, IMovement
    {
        public Soldier() { }

        public abstract void Move();
    }
}
