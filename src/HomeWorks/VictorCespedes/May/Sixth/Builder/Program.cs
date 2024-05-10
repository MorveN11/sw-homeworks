using System;

public class Character
{
    public string Name { get; set; }
    public int Strength { get; set; }
    public int Agility { get; set; }
    public int Intelligence { get; set; }
    public int Endurance { get; set; }

    public override string ToString()
    {
        return $"Name: {Name}, Strength: {Strength}, Agility: {Agility}, Intelligence: {Intelligence}, Endurance: {Endurance}";
    }
}

public interface ICharacterBuilder
{
    void SetName(string name);
    void SetStrength(int strength);
    void SetAgility(int agility);
    void SetIntelligence(int intelligence);
    void SetEndurance(int endurance);
    Character GetCharacter();
}

public class CharacterBuilder : ICharacterBuilder
{
    private Character _character = new Character();

    public void SetName(string name)
    {
        _character.Name = name;
    }

    public void SetStrength(int strength)
    {
        _character.Strength = strength;
    }

    public void SetAgility(int agility)
    {
        _character.Agility = agility;
    }

    public void SetIntelligence(int intelligence)
    {
        _character.Intelligence = intelligence;
    }

    public void SetEndurance(int endurance)
    {
        _character.Endurance = endurance;
    }

    public Character GetCharacter()
    {
        return _character;
    }
}

public class CharacterCreator
{
    private readonly ICharacterBuilder _builder;

    public CharacterCreator(ICharacterBuilder builder)
    {
        _builder = builder;
    }

    public void CreateCharacter(string name, int strength, int agility, int intelligence, int endurance)
    {
        _builder.SetName(name);
        _builder.SetStrength(strength);
        _builder.SetAgility(agility);
        _builder.SetIntelligence(intelligence);
        _builder.SetEndurance(endurance);
    }
}

class Program
{
    static void Main(string[] args)
    {
        ICharacterBuilder builder = new CharacterBuilder();
        CharacterCreator creator = new CharacterCreator(builder);

        creator.CreateCharacter("Warrior", 10, 5, 3, 8);
        Character warrior = builder.GetCharacter();
        Console.WriteLine("Warrior Character: " + warrior);

        creator.CreateCharacter("Mage", 3, 4, 10, 5);
        Character mage = builder.GetCharacter();
        Console.WriteLine("Mage Character: " + mage);
    }
}
