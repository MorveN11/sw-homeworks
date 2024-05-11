namespace DecoratorDesignPattern
{
    class Program
    {
        static void Main()
        {
            Database db = new Database();
            IDBRemote dbRemote = new DBRemote(db);

            dbRemote.Connect();
            List<User> users = dbRemote.GetUsers();
            PrintUsers(users);


            Console.WriteLine();

            List<Music> music = dbRemote.GetMusic();
            PrintMusic(music);


           dbRemote.CloseConnection();
        }


        public static void PrintUsers(List<User> users)
        {
            Console.WriteLine("Users:");
            foreach (var user in users)
            {
                Console.WriteLine($"Name: {user.Name}, Email: {user.Email}");
            }
        }


        public static void PrintMusic(List<Music> music)
        {
            Console.WriteLine("Music:");
            foreach (var song in music)
            {
                Console.WriteLine($"Name: {song.Name}, Author: {song.Author}");
            }
        }
    }

    public class User
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
    }

    public class Music
    {
        public string? Name { get; set; }
        public string? Author { get; set; }
    }

    public interface IDatabase
    {
        List<User> GetUsers();
        List<Music> GetMusic();
    }

    public interface IDBRemote : IDatabase
    {
        void Connect();
        void CloseConnection();
    }

    public class Database : IDatabase
    {
        public List<User> GetUsers()
        {
            return [new () { Name = "dani", Email = "dani@gmail.com" }];
        }

        public List<Music> GetMusic()
        {
            return [ new() { Author = "Frank Sinatra", Name = "Fly me to the moon" }];
        }
    }

    public abstract class DBDecorator(IDatabase database) : IDatabase
    {
        protected IDatabase _database = database;

        public virtual List<User> GetUsers()
        {
            return _database.GetUsers();
        }

        public virtual List<Music> GetMusic()
        {
            return _database.GetMusic();
        }
    }

    public class DBRemote(IDatabase database) : DBDecorator(database), IDBRemote
    {
        public void Connect()
        {
            Console.WriteLine("Connected");
        }

        public void CloseConnection()
        {
            Console.WriteLine("Closed");
        }
    }
}
