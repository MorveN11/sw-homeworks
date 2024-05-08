public class GameEnemyFactory : EnemyFactory
{
    public GameEnemyFactory() { }

    public Enemy CreateNormalEnemy()
    {
        return new GameNormalEnemy();
    }

    public Enemy CreateBossEnemy()
    {
        return new GameBossEnemy();
    }
}
