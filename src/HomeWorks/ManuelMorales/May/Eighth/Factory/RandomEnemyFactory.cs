public class RandomEnemyFactory : IEnemyFactory
{
    public IEntity CreateEnemy()
    {
        Random random = new Random();
        int randomNumber = random.Next(0, 3);

        if (randomNumber == 0)
        {
            return new Goomba();
        }

        if (randomNumber == 1)
        {
            return new Kooopa();
        }

        return new Boo();
    }
}
