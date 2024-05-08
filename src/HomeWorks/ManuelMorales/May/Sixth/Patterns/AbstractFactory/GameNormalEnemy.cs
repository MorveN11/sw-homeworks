public class GameNormalEnemy : Enemy
{
    public GameNormalEnemy()
        : base(100, 20, 30) { }

    public override void Attack()
    {
        Console.WriteLine("Normal Enemy is attacking");
    }

    public override void Move()
    {
        Console.WriteLine("Normal Enemy is moving");
    }
}
