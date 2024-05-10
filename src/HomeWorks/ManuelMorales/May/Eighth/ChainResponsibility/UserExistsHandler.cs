public class UserExistsHandler : LoginHandler
{
    public UserExistsHandler(Database database)
        : base(database) { }

    public override bool HandleRequest(String userName, String password)
    {
        if (!_database.IsValidUser(userName, password))
        {
            Console.WriteLine($"User {userName} does not exist");
            return false;
        }

        return base.HandleRequest(userName, password);
    }
}
