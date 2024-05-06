using System;

abstract class Character{
    public void Attack(){
        PrepareForAttack();
        PerformAttack();
        FinishAttack();
    }

    protected abstract void PerformAttack();

    protected abstract void PrepareForAttack();

    protected void FinishAttack(){
        Console.WriteLine("The attack has finished.");
    }
}

class Warrior : Character{
    protected override void PrepareForAttack(){
        Console.WriteLine("The warrior prepares to attack.");
    }

    protected override void PerformAttack(){
        Console.WriteLine("The warrior attacks with his sword.");
    }
}

class Mage : Character{
    protected override void PrepareForAttack(){
        Console.WriteLine("The mage prepares to attack.");
    }

    protected override void PerformAttack(){
        Console.WriteLine("The mage casts a spell.");
    }
}

class Program{
    static void Main(string[] args){
        Character warrior = new Warrior();
        Character mage = new Mage();

        warrior.Attack();

        Console.WriteLine();

        mage.Attack();
    }
}
