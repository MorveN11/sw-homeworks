using System;


public interface ICharacter
{
    void Display();
}


public class Player : ICharacter
{
    public void Display()
    {
        Console.WriteLine("Player character displayed.");
    }
}


public abstract class CharacterDecorator : ICharacter
{
    protected ICharacter character;

    public CharacterDecorator(ICharacter character)
    {
        this.character = character;
    }

    public virtual void Display()
    {
        character.Display();
    }
}

public class ArmorDecorator : CharacterDecorator
{
    public ArmorDecorator(ICharacter character) : base(character) { }

    public override void Display()
    {
        base.Display();
        EquipArmor();
    }

    private void EquipArmor()
    {
        Console.WriteLine("Armor equipped.");
    }
}

public class WeaponDecorator : CharacterDecorator
{
    public WeaponDecorator(ICharacter character) : base(character) { }

    public override void Display()
    {
        base.Display();
        EquipWeapon();
    }

    private void EquipWeapon()
    {
        Console.WriteLine("Weapon equipped.");
    }
}


public class Program
{
    public static void Main()
    {
        ICharacter player = new Player();

        player = new ArmorDecorator(player);
        player.Display();

        Console.WriteLine();

        player = new WeaponDecorator(player);
        player.Display();
    }
}

