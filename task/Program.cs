namespace Functional
{
  public class Program
  {
    public delegate TOut Getter<TOut>();

    public delegate void Setter<TIn>(TIn value);
    
    public delegate bool Predicate<TIn>(TIn value);
    
    public delegate bool Predicate();

    public delegate void FunctionTalk();
    
//   public delegate (Getter<string> getName, Setter<string>setName, Getter<DateTime>getBirthDay, Setter<DateTime>setBirthDay) Person(String name, DateTime birthDay);

  //  public static Tuple<Getter<string>, Setter<string>, Getter<DateTime>, Setter<DateTime>> PersonItem(String name, DateTime birthDay)
  public static (Getter<string> getName, Setter<string> setName, Getter<DateTime> getBirthDay, Setter<DateTime> setBirthDay, FunctionTalk talk) Person(String name, DateTime birthDay)
    {
      Getter<string> getName = () => name;
      Getter<DateTime> getBirtDay = () => birthDay;

      Setter<string> setName = value => { name = value; };
      Setter<DateTime> setBirthDay = value => { birthDay = value; };

      FunctionTalk talk = () => { Console.WriteLine("Hola"); };
      return new (getName, setName, getBirtDay, setBirthDay, talk);
    }
  
    public static (Getter<string> getName, Setter<string> setName, Getter<DateTime> getBirthDay, Setter<DateTime> setBirthDay, Getter<byte> getGrade, Setter<byte> setGrade, Predicate aproved, Action talk) Student(String name, DateTime birthDay, byte grade)
    {
      var super = Person(name, birthDay);
      Getter<byte> getGrade = () => grade;

      Setter<byte> setGrade = value => { grade = value; };

      Predicate aproved = () => grade >= 6 && grade <= 10;

      var talk = () => { Console.WriteLine("Hola"); };

      return (super.getName, super.setName, super.getBirthDay, super.setBirthDay, getGrade, setGrade, aproved, talk);
    }


    public static void Main()
    {
      var p1 = Person("Juan", new DateTime(1, 2, 3));

      Console.WriteLine(p1.getName());
      p1.setName("Marta");
      Console.WriteLine(p1.getName());

    }

  }
}