using System;

// Hecho en clase

interface IPupet{
    void performAct();
}

class Warrior : IPupet{
    public void performAct(){
        attack();
        defends();
    }

    public void attack(){
        Console.WriteLine("The warrior performs an attack.");
    }

    public void defends(){
        Console.WriteLine("The warrior defends himself with his shield.");
    }
}

class Princes : IPupet{
    public void performAct(){
        sing();
        dancing();
    }

    public void sing(){
        Console.WriteLine("The princess begins to sing.");
    }

    public void dancing(){
        Console.WriteLine("The princess dances while singing.");
    }
}

class Titiritero{
    private IPupet pupet;

    public Titiritero(IPupet pupet){
        this.pupet = pupet;
    }

    public void setPupet(IPupet pupet){
        this.pupet = pupet;
    }

    public void performance(){
        pupet.performAct();
    }
}

class Program{
    static void Main(string[] args){
        Titiritero titritero = new Titiritero(new Warrior());
        titritero.performance();

        Console.WriteLine();

        titritero.setPupet(new Princes());
        titritero.performance();
    }
}
