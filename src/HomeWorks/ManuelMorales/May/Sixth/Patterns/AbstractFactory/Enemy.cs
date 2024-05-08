public abstract class Enemy
{
    private readonly int _health;
    private readonly int _damage;
    private readonly int _defense;

    public Enemy(int health, int damage, int defense)
    {
        _health = health;
        _damage = damage;
        _defense = defense;
    }

    public int Health => _health;
    public int Damage => _damage;
    public int Defense => _defense;

    public abstract void Attack();
    public abstract void Move();
}
