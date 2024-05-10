public class Game
{
    private IEnemyFactory _enemyFactory;

    public Game(IEnemyFactory enemyFactory)
    {
        _enemyFactory = enemyFactory;
    }

    public void SetEnemyFactory(IEnemyFactory enemyFactory) => _enemyFactory = enemyFactory;

    public void SpawnEnemy()
    {
        IEntity enemy = _enemyFactory.CreateEnemy();

        enemy.Update();
    }
}
