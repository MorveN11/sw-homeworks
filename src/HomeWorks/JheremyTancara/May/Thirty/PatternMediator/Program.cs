using System;
using System.Collections.Generic;

public interface IChatMediator
{
    void SendMessage(string message, IUser user);
    void AddUser(IUser user);
}

public class ChatMediator : IChatMediator
{
    private List<IUser> users;

    public ChatMediator()
    {
        users = new List<IUser>();
    }

    public void AddUser(IUser user)
    {
        users.Add(user);
    }

    public void SendMessage(string message, IUser user)
    {
        foreach (var u in users)
        {
            if (u != user)
                u.ReceiveMessage(message);
        }
    }
}

public interface IUser
{
    void SendMessage(string message);
    void ReceiveMessage(string message);
}

public class User : IUser
{
    private string name;
    private IChatMediator mediator;

    public User(string name, IChatMediator mediator)
    {
        this.name = name;
        this.mediator = mediator;
    }

    public void SendMessage(string message)
    {
        Console.WriteLine($"{name} sending message: {message}");
        mediator.SendMessage(message, this);
    }

    public void ReceiveMessage(string message)
    {
        Console.WriteLine($"{name} received message: {message}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        IChatMediator mediator = new ChatMediator();

        IUser user1 = new User("Ronaldo", mediator);
        IUser user2 = new User("Rodrigo", mediator);
        IUser user3 = new User("Andre", mediator);

        mediator.AddUser(user1);
        mediator.AddUser(user2);
        mediator.AddUser(user3);

        user1.SendMessage("Friasooo malll!");
    }
}
