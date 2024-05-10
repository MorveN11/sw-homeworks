public class GoombaFactory : IEnemyFactory
{
    public IEntity CreateEnemy()
    {
        return new Goomba();
    }
}
