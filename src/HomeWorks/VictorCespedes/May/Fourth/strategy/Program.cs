using System;

interface IAttackStrategy{
    void Prepare();
    void Attack();
    void Escape();
}

class MeleeAttack : IAttackStrategy{
    public void Prepare(){
        Console.WriteLine("the character prepares to attack the enemy.");
    }

    public void Attack(){
        Console.WriteLine("Performs a melee attack.");
    }

    public void Escape(){
        Console.WriteLine("the character sees the enemy team and starts the escape.");
    }
}

class RangedAttack : IAttackStrategy{
    public void Prepare(){
        Console.WriteLine("the character prepares to attack the enemy.");
    }

    public void Attack(){
        Console.WriteLine("Performs a ranged attack.");
    }

    public void Escape(){
        Console.WriteLine("the character sees the enemy team and decides not to escape because he is far away from them.");
    }
}

class Character{
    private IAttackStrategy attackStrategy;

    public Character(IAttackStrategy strategy){
        attackStrategy = strategy;
    }

    public void SetAttackStrategy(IAttackStrategy strategy){
        attackStrategy = strategy;
    }

    public void Attack(){
        attackStrategy.Prepare();
        attackStrategy.Attack();
        attackStrategy.Escape();
    }
}

class Program{
    static void Main(string[] args){
        Character warrior = new Character(new MeleeAttack());
        warrior.Attack();

        Console.WriteLine();

        Character archer = new Character(new RangedAttack());
        archer.Attack();
    }
}
