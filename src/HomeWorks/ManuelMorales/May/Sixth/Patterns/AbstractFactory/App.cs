public class App
{
    public static void Main()
    {
        var gameEnemyFactory = new GameEnemyFactory();
        var normalEnemy = gameEnemyFactory.CreateNormalEnemy();
        var bossEnemy = gameEnemyFactory.CreateBossEnemy();
        Console.WriteLine("Normal Enemy");
        Console.WriteLine($"Health: {normalEnemy.Health}");
        Console.WriteLine($"Damage: {normalEnemy.Damage}");
        Console.WriteLine($"Defense: {normalEnemy.Defense}");
        normalEnemy.Attack();
        normalEnemy.Move();

        Console.WriteLine("\nBoss Enemy");
        Console.WriteLine($"Health: {bossEnemy.Health}");
        Console.WriteLine($"Damage: {bossEnemy.Damage}");
        Console.WriteLine($"Defense: {bossEnemy.Defense}");
        bossEnemy.Attack();
        bossEnemy.Move();
    }
}
