public class GameBossEnemy : Enemy
{
    public GameBossEnemy()
        : base(300, 50, 100) { }

    public override void Attack()
    {
        Console.WriteLine("Boss Enemy is attacking");
    }

    public override void Move()
    {
        Console.WriteLine("Boss Enemy is moving");
    }
}
