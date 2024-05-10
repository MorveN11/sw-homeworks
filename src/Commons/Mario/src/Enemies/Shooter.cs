namespace Mario.Enemies
{
    public class Shooter : Soldier
    {
        public Shooter() { }

        public override void Attack()
        {
            Console.WriteLine("Shooter Attack");
        }

        public override void Move()
        {
            Console.WriteLine("Shooter Move");
        }
    }
}
