using System;

public interface ICharacterFactory
{
    ICharacter CreatePlayer();
    ICharacter CreateEnemy();
}

public interface ICharacter
{
    void Display();
}

public abstract class Character : ICharacter
{
    public abstract void Display();
}

public class HumanCharacter : Character
{
    public override void Display()
    {
        Console.WriteLine("Humano creado.");
    }
}

public class OrcCharacter : Character
{
    public override void Display()
    {
        Console.WriteLine("Orco creado.");
    }
}

public class HumanCharacterFactory : ICharacterFactory
{
    public ICharacter CreatePlayer()
    {
        return new HumanCharacter();
    }

    public ICharacter CreateEnemy()
    {
        return new HumanCharacter();
    }
}

public class OrcCharacterFactory : ICharacterFactory
{
    public ICharacter CreatePlayer()
    {
        return new OrcCharacter();
    }

    public ICharacter CreateEnemy()
    {
        return new OrcCharacter();
    }
}

class Program
{
    static void Main(string[] args)
    {
        ICharacterFactory humanFactory = new HumanCharacterFactory();
        ICharacter humanPlayer = humanFactory.CreatePlayer();
        ICharacter humanEnemy = humanFactory.CreateEnemy();

        Console.WriteLine("Personajes humanos:");
        humanPlayer.Display();
        humanEnemy.Display();

        ICharacterFactory orcFactory = new OrcCharacterFactory();
        ICharacter orcPlayer = orcFactory.CreatePlayer();
        ICharacter orcEnemy = orcFactory.CreateEnemy();

        Console.WriteLine("\nPersonajes orcos:");
        orcPlayer.Display();
        orcEnemy.Display();
    }
}
