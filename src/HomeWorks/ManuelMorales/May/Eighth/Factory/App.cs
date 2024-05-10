public class App
{
    static void Main(String[] args)
    {
        Game game = new Game(new GoombaFactory());
        game.SpawnEnemy();
        game.SpawnEnemy();

        game.SetEnemyFactory(new RandomEnemyFactory());

        game.SpawnEnemy();
        game.SpawnEnemy();
    }
}
